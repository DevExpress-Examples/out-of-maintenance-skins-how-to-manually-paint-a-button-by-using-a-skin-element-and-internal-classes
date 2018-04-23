Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.Utils
Imports DevExpress.Utils.Drawing

Namespace DXApplication191
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Private _helper As SkinButtonPaintHelper
        Public Sub New()
            InitializeComponent()
            _helper = New SkinButtonPaintHelper() With {.ButtonImage = My.Resources.open_32x32, .ButtonRectangle = New Rectangle(5, 5, 200, 80), .ButtonText = "Manually painted"}
        End Sub
        Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
            MyBase.OnPaint(e)
            _helper.DrawButton(e, ObjectState.Normal)
        End Sub
    End Class

End Namespace
