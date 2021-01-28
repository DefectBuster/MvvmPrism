// ***********************************************************************
// <copyright file="CustomComboBox.cs" company="Schneider Electric">
//     Copyright (c) 2019, Schneider Electric, All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
// ***********************************************************************

using System.Windows;

using System;
using System.Collections.Generic;
using Telerik.Windows.Controls;
using System.Collections.ObjectModel;
using System.Linq;

using System.Collections.Specialized;
using System.Windows.Input;

namespace ComboboxRedBorderValidation
{
    /// <summary>
    /// Custom ComboBox
    /// </summary>
    /// <seealso cref="Telerik.Windows.Controls.RadComboBox" />
    public class CustomComboBox : RadComboBox
    {
        /// <summary>
        /// The is loaded
        /// </summary>
        private bool isLoaded = false;
        /// <summary>
        /// The is initialized from enter key event
        /// </summary>
        private bool isInitializedFromEnterKeyEvent = false;
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomComboBox"/> class.
        /// </summary>
        public CustomComboBox()
        {
            this.SelectionChanged += (s, a) =>
            {
                if (isLoaded || isInitializedFromEnterKeyEvent)
                {
                    if (this.AllowMultipleSelection)
                    {
                        if (!Equals(this.SelectedItems, null) && this.SelectedItems.Count > 0)
                        {
                            if (!Equals(this.SelectedASPTemplates, null))
                                this.SelectedASPTemplates.Clear();
                            List<MyClass> models = new List<MyClass>();
                            foreach (var aspModel in this.SelectedItems)
                            {
                                models.Add((MyClass)aspModel);
                            }

                            this.SelectedASPTemplates = new ObservableCollection<MyClass>(models);
                        }
                    }

                }
            };
        }

        /// <summary>
        /// Gets or sets the update.
        /// </summary>
        /// <value>
        /// The update.
        /// </value>
        public Action<string, bool> update { get; set; }
        /// <summary>
        /// AssetClassModel dependency property.
        /// </summary>
        public static readonly DependencyProperty SelectedASPTemplatesProperty =
            DependencyProperty.Register("SelectedASPTemplates", typeof(ObservableCollection<MyClass>), typeof(CustomComboBox), new PropertyMetadata(OnSelectedItemsPropertyChanged));

        /// <summary>
        /// Gets or sets the AssetClassModel property.
        /// This is a dependency property.
        /// </summary>
        /// <value>
        /// The selected ASP templates.
        /// </value>
        public ObservableCollection<MyClass> SelectedASPTemplates
        {
            get { return (ObservableCollection<MyClass>)GetValue(CustomComboBox.SelectedASPTemplatesProperty); }
            set
            {
                this.SetValue(CustomComboBox.SelectedASPTemplatesProperty, value);
            }
        }
        /// <summary>
        /// Called when [selected items property changed].
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="args">The <see cref="DependencyPropertyChangedEventArgs"/> instance containing the event data.</param>
        private static void OnSelectedItemsPropertyChanged(DependencyObject target, DependencyPropertyChangedEventArgs args)
        {
            var collection = args.NewValue as ObservableCollection<MyClass>;
            if (collection != null)
            {
                ((CustomComboBox)target).LoadSelectedItems(collection);
            }
        }
        /// <summary>
        /// Updates the current selection when an item in the <see cref="T:System.Windows.Controls.Primitives.Selector" /> has changed
        /// </summary>
        /// <param name="e">The event data.</param>
        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e)
        {
            base.OnItemsChanged(e);
        }
        /// <summary>
        /// Loads the selected items.
        /// </summary>
        /// <param name="selected">The selected.</param>
        private void LoadSelectedItems(ObservableCollection<MyClass> selected)
        {
            if (!isLoaded && !Equals(this.ItemsSource, null))
            {
                                if (this.AllowMultipleSelection)
                {
                    foreach (MyClass aspModel in selected)
                    {
                        var template = ((ObservableCollection<MyClass>)this.ItemsSource).FirstOrDefault(x => x.Name == aspModel.Name);
                        if (template != null)
                        {
                            //template.IsDefault = aspModel.IsDefault;
                        }
                        this.SelectedItems.Add(template);
                    }
                }
                isLoaded = true;
            }
        }

        #region Enter Key

        /// <summary>
        /// The accepts enter key property
        /// </summary>
        public static readonly DependencyProperty AcceptsEnterKeyProperty =
       DependencyProperty.Register("AcceptsEnterKey", typeof(bool), typeof(CustomComboBox), new PropertyMetadata(default(bool), OnAcceptsEnterKey));

        /// <summary>
        /// Sets the accepts enter key.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="value">if set to <c>true</c> [value].</param>
        public static void SetAcceptsEnterKey(DependencyObject element, bool value)
        {
            element.SetValue(AcceptsEnterKeyProperty, value);
        }

        /// <summary>
        /// Gets the accepts enter key.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <returns></returns>
        public static bool GetAcceptsEnterKey(DependencyObject element)
        {
            return (bool)element.GetValue(AcceptsEnterKeyProperty);
        }

        /// <summary>
        /// Called when [accepts enter key].
        /// </summary>
        /// <param name="dependencyObject">The dependency object.</param>
        /// <param name="eventArgs">The <see cref="DependencyPropertyChangedEventArgs"/> instance containing the event data.</param>
        private static void OnAcceptsEnterKey(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs eventArgs)
        {
            //var element = (UIElement)dependencyObject;
            ((CustomComboBox)dependencyObject).LoadEvents((bool)eventArgs.NewValue);
        }

        /// <summary>
        /// Loads the events.
        /// </summary>
        /// <param name="isEditable">if set to <c>true</c> [is editable].</param>
        private void LoadEvents(bool isEditable)
        {
            if (isEditable)
            {
                PreviewKeyDown += KeyDownPreview;
            }
            else
            {
                PreviewKeyDown -= KeyDownPreview;
            }
        }
        /// <summary>
        /// Keys down preview.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
        private void KeyDownPreview(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Return)
            {
                if (Equals(this.ItemsSource, null))
                {
                    this.ItemsSource = new ObservableCollection<MyClass>()
                    {
                        new MyClass()
                        {
                            Name = this.Text ,
                            //UpdateSelectedASPTemplates=(aspTemplate,isDefault)=>
                            //{
                            //    if(isDefault&!Equals(this.ItemsSource,null))
                            //    {
                            //        ((ObservableCollection<MyClass>)this.ItemsSource).ToList().Where(x => x.Name != aspTemplate && isDefault).ToList().ForEach((template) =>
                            //        {
                            //            template.IsDefault=false;
                            //        });
                            //    }
                            //}
                        }
                    };

                }
                else
                {
                    var source = ((ObservableCollection<MyClass>)this.ItemsSource);
                    if (!source.Any(x => x.Name == this.Text))
                    {
                        source.Add(new MyClass()
                        {
                            Name = this.Text,
                            //UpdateSelectedASPTemplates = (aspTemplate, isDefault) =>
                            //{
                            //    if (isDefault & !Equals(this.ItemsSource, null))
                            //    {
                            //        source.ToList().Where(x => x.Name != aspTemplate && isDefault).ToList().ForEach((template) =>
                            //        {
                            //            template.IsDefault = false;
                            //        });
                            //    }
                            //}
                        });
                    }
                }
                isInitializedFromEnterKeyEvent = true;
                Text = string.Empty;
            }
        }

        #endregion
    }
}
