using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;

namespace DXApplication191 {
    class SkinButtonPaintHelper {
        DevExpress.Utils.AppearanceObject _appearance;
        Image _image;
        Rectangle _buttonRectangle;
        public AppearanceObject AppearanceObject {
            get {
                if (_appearance == null)
                    _appearance = new AppearanceObject();
                return _appearance;
            }
            set {
                _appearance = value;
            }
        }
        public Image ButtonImage {
            get { return _image; }
            set { _image = value; }
        }
        public Rectangle ButtonRectangle { get { return _buttonRectangle; } set { _buttonRectangle = value; } }
        public string ButtonText { get; set; }
        public SkinButtonPaintHelper() {
            AppearanceObject.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            AppearanceObject.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
        }
        public void DrawButton(PaintEventArgs args, ObjectState state) {
            using (GraphicsCache cache = new GraphicsCache(args)) {
                SkinElement element = CommonSkins.GetSkin(UserLookAndFeel.Default)[CommonSkins.SkinButton];
                SkinElementInfo info = new SkinElementInfo(element, ButtonRectangle);

                if (state == ObjectState.Normal) info.ImageIndex = 0;
                if (state == ObjectState.Hot) info.ImageIndex = 1;
                if (state == ObjectState.Pressed) info.ImageIndex = 2;
                DrawSkinImage(cache, info);
                DrawText(cache);
                DrawImage(cache);
            }
        }

        void DrawSkinImage(GraphicsCache cache, SkinElementInfo info) {
            ObjectPainter.DrawObject(cache, SkinElementPainter.Default, info);
        }

        void DrawText(GraphicsCache cache) {
            AppearanceObject.DrawString(cache, ButtonText, ButtonRectangle);
        }
        void DrawImage(GraphicsCache cache) {
            if (ButtonImage == null) return;
            Rectangle imageBounds = GetImageBounds(ButtonRectangle, ButtonImage.Size);
            cache.Graphics.DrawImage(ButtonImage, imageBounds);
        }

        Rectangle GetImageBounds(Rectangle buttonBounds, Size imageSize) {
            return ImageLayoutHelper.GetImageBounds(buttonBounds, imageSize, ImageScaleMode.Clip, ImageAlignmentMode.MiddleLeft);
        }
    }
}
