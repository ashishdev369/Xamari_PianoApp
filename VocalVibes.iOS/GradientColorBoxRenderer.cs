using System;
using CoreAnimation;
using CoreGraphics;
using VocalVibes;
using VocalVibes.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(GradientColorBox), typeof(GradientColorBoxRenderer))]

namespace VocalVibes.iOS
{
    public class GradientColorBoxRenderer : VisualElementRenderer<StackLayout>
    {
        public override void Draw(CGRect rect)
        {
            base.Draw(rect);
            GradientColorBox stack = (GradientColorBox)this.Element;
            CGColor startColor = stack.StartColor.ToCGColor();

            CGColor endColor = stack.EndColor.ToCGColor();

            #region for Vertical Gradient

            //var gradientLayer = new CAGradientLayer();

            #endregion

            #region for Horizontal Gradient

            var gradientLayer = new CAGradientLayer()
            {
              StartPoint = new CGPoint(0, 0.5),
              EndPoint = new CGPoint(1, 0.5)
            };

            #endregion



            gradientLayer.Frame = rect;
            gradientLayer.Colors = new CGColor[] { startColor, endColor
        };

            NativeView.Layer.InsertSublayer(gradientLayer, 0);
        }
    }
}