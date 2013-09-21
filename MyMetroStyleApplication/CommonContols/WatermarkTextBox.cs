using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CommonControls
{
    /// <summary>
    /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
    ///
    /// Step 1a) Using this custom control in a XAML file that exists in the current project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CommonContols"
    ///
    ///
    /// Step 1b) Using this custom control in a XAML file that exists in a different project.
    /// Add this XmlNamespace attribute to the root element of the markup file where it is 
    /// to be used:
    ///
    ///     xmlns:MyNamespace="clr-namespace:CommonContols;assembly=CommonContols"
    ///
    /// You will also need to add a project reference from the project where the XAML file lives
    /// to this project and Rebuild to avoid compilation errors:
    ///
    ///     Right click on the target project in the Solution Explorer and
    ///     "Add Reference"->"Projects"->[Select this project]
    ///
    ///
    /// Step 2)
    /// Go ahead and use your control in the XAML file.
    ///
    ///     <MyNamespace:CustomControl1/>
    ///
    /// </summary>

    public class WatermarkTextBox : TextBox
    {
        #region Properties

        #region SelectAllOnGotFocus

        public static readonly DependencyProperty SelectAllOnGotFocusProperty = 
            DependencyProperty.Register("SelectAllOnGotFocus", typeof(bool), typeof(WatermarkTextBox), new PropertyMetadata(false));
        public bool SelectAllOnGotFocus
        {
            get
            {
                return (bool)GetValue(SelectAllOnGotFocusProperty);
            }
            set
            {
                SetValue(SelectAllOnGotFocusProperty, value);
            }
        }

        #endregion //SelectAllOnGotFocus

        #region Watermark

        public static readonly DependencyProperty WatermarkProperty = 
            DependencyProperty.Register("Watermark", typeof(object), typeof(WatermarkTextBox), new UIPropertyMetadata(null));
        public object Watermark
        {
            get
            {
                return (object)GetValue(WatermarkProperty);
            }
            set
            {
                SetValue(WatermarkProperty, value);
            }
        }

        #endregion //Watermark

        #region WatermarkTemplate

        public static readonly DependencyProperty WatermarkTemplateProperty = 
            DependencyProperty.Register("WatermarkTemplate", typeof(DataTemplate), typeof(WatermarkTextBox), new UIPropertyMetadata(null));
        public DataTemplate WatermarkTemplate
        {
            get
            {
                return (DataTemplate)GetValue(WatermarkTemplateProperty);
            }
            set
            {
                SetValue(WatermarkTemplateProperty, value);
            }
        }

        #endregion //WatermarkTemplate

        #endregion //Properties

        #region Constructors

        static WatermarkTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WatermarkTextBox), new FrameworkPropertyMetadata(typeof(WatermarkTextBox)));
        }

        #endregion //Constructors

        #region Base Class Overrides

        protected override void OnGotFocus(RoutedEventArgs e)
        {
            base.OnGotFocus(e);

            if (SelectAllOnGotFocus)
                SelectAll();
        }

        protected override void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            if (!IsKeyboardFocused && SelectAllOnGotFocus)
            {
                e.Handled = true;
                Focus();
            }

            base.OnPreviewMouseLeftButtonDown(e);
        }

        #endregion //Base Class Overrides
    }
}
