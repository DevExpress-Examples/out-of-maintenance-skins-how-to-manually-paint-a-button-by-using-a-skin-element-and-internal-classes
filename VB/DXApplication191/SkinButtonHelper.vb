Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing

Namespace DXApplication191
    Friend Class SkinButtonPaintHelper
        Private _appearance As DevExpress.Utils.AppearanceObject
        Private _image As Image
        Private _buttonRectangle As Rectangle
        Public Property AppearanceObject() As AppearanceObject
            Get
                If _appearance Is Nothing Then
                    _appearance = New AppearanceObject()
                End If
                Return _appearance
            End Get
            Set(ByVal value As AppearanceObject)
                _appearance = value
            End Set
        End Property
        Public Property ButtonImage() As Image
            Get
                Return _image
            End Get
            Set(ByVal value As Image)
                _image = value
            End Set
        End Property
        Public Property ButtonRectangle() As Rectangle
            Get
                Return _buttonRectangle
            End Get
            Set(ByVal value As Rectangle)
                _buttonRectangle = value
            End Set
        End Property
        Public Property ButtonText() As String
        Public Sub New()
            AppearanceObject.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            AppearanceObject.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        End Sub
        Public Sub DrawButton(ByVal args As PaintEventArgs, ByVal state As ObjectState)
            Using cache As New GraphicsCache(args)
                Dim element As SkinElement = CommonSkins.GetSkin(UserLookAndFeel.Default)(CommonSkins.SkinButton)
                Dim info As New SkinElementInfo(element, ButtonRectangle)

                If state = ObjectState.Normal Then
                    info.ImageIndex = 0
                End If
                If state = ObjectState.Hot Then
                    info.ImageIndex = 1
                End If
                If state = ObjectState.Pressed Then
                    info.ImageIndex = 2
                End If
                DrawSkinImage(cache, info)
                DrawText(cache)
                DrawImage(cache)
            End Using
        End Sub

        Private Sub DrawSkinImage(ByVal cache As GraphicsCache, ByVal info As SkinElementInfo)
            ObjectPainter.DrawObject(cache, SkinElementPainter.Default, info)
        End Sub

        Private Sub DrawText(ByVal cache As GraphicsCache)
            AppearanceObject.DrawString(cache, ButtonText, ButtonRectangle)
        End Sub
        Private Sub DrawImage(ByVal cache As GraphicsCache)
            If ButtonImage Is Nothing Then
                Return
            End If
            Dim imageBounds As Rectangle = GetImageBounds(ButtonRectangle, ButtonImage.Size)
            cache.Graphics.DrawImage(ButtonImage, imageBounds)
        End Sub

        Private Function GetImageBounds(ByVal buttonBounds As Rectangle, ByVal imageSize As Size) As Rectangle
            Return ImageLayoutHelper.GetImageBounds(buttonBounds, imageSize, ImageScaleMode.Clip, ImageAlignmentMode.MiddleLeft)
        End Function
    End Class
End Namespace
