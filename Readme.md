<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/DXApplication191/Form1.cs) (VB: [Form1.vb](./VB/DXApplication191/Form1.vb))
* [Program.cs](./CS/DXApplication191/Program.cs) (VB: [Program.vb](./VB/DXApplication191/Program.vb))
* **[SkinButtonHelper.cs](./CS/DXApplication191/SkinButtonHelper.cs) (VB: [SkinButtonHelper.vb](./VB/DXApplication191/SkinButtonHelper.vb))**
<!-- default file list end -->
# Skins - How to manually paint a button by using a skin element and internal classes


<p>If you have a control and want to place a button to one of its part, but the control does not support this, there is a way to draw a button using a corresponding skin element image. This example illustrates how to paint a SimpleButton on any control using the ObjectPainter and ImageLayoutHelper classes. The ObjectPainter class paints an object by using a SkinElementInfo object that can be easily created. The ImageLayoutHelper class is a helper that calculates the location of an image within given boundaries. Here is an image of a manually painted button:</p>
<img src="https://raw.githubusercontent.com/DevExpress-Examples/skins-how-to-manually-paint-a-button-by-using-a-skin-element-and-internal-classes-t498252/16.1.4+/media/d657cb1f-153c-11e7-80bf-00155d62480c.png"><br>
<p>The <a href="https://www.devexpress.com/Support/Center/p/T498132">GridControl - How to draw a button in a group header when TileView's is used in Kanban mode</a> example uses the same technique to paint a button within boundaries of TileControl's group.</p>

<br/>


