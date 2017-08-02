using System;
using System.Diagnostics;
using System.Numerics;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.System;
using Windows.UI;
using Windows.UI.Composition;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

using Caliburn.Micro;
using Windows.UI.Xaml.Media.Animation;
using System.ComponentModel;

namespace CaliburnMicroCustomControl.Controls
{
    #region TemplatePart Attribute for Blend
    [TemplatePart(Name = ContainerPartName, Type = typeof(Grid))]
    [TemplatePart(Name = TitlePartName, Type = typeof(TextBlock))]
    #endregion


    public class SensorMeter : Control
    {

        #region DependencyProperty
        public static readonly DependencyProperty Title_TextProperty =
            DependencyProperty.Register(nameof(Title_Text), typeof(string), typeof(SensorMeter), new PropertyMetadata("HelloTest", OnValueChanged));

        #endregion

        public string _title_Text2 = "ByeBye Default";

        #region CLR_Properties
        /* -----------------------------------------Property for DependencyProperty-------------------------------------------- */
        public string Title_Text
        {
            get { return (string)GetValue(Title_TextProperty); }
            set { SetValue(Title_TextProperty, value); }
        }
        public string Title_Text2 {
            get { return _title_Text2; }
            set { this.Set(_title_Text2); }  // This line has error !!
        }

        #endregion

        #region Template Parts name by Const
        // Template Parts.
        private const string ContainerPartName = "PART_Container";
        private const string TitlePartName = "PART_Title";
        private const string TitlePart2Name = "PART_Title2";

        
        #endregion

        public SensorMeter()
        {
            DefaultStyleKey = typeof(SensorMeter);


        }
        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            /* SensorMeter sensorMeter = this;
            var _title = sensorMeter.GetTemplateChild(TitlePart2Name) as TextBlock;
            if (_title != null)
            {
                _title.Text = "ByeBye by GetTemplateChild";
            }*/

        }

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            OnValueChanged(d);
        }

        private static void OnValueChanged(DependencyObject d)
        {
            
            
        }
    }
}
