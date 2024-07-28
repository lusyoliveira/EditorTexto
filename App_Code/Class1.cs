using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AjaxControlToolkit.HTMLEditor;

namespace MyControls 
{ 
    public class CustomEditor : Editor
    { 
        
        protected override void FillTopToolbar()
        {
                        TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.Undo());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.Redo());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.HorizontalSeparator());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.Copy());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.Paste());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.PasteText());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.PasteWord());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.Cut());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.HorizontalSeparator());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.FixedForeColor());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.ForeColorSelector());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.FixedBackColor());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.BackColorSelector());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.HorizontalSeparator());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.FontName());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.FontSize());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.HorizontalSeparator());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.JustifyLeft());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.JustifyCenter());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.JustifyFull());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.JustifyRight());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.RemoveAlignment());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.HorizontalSeparator());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.Ltr());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.Rtl());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.Paragraph());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.HorizontalSeparator());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.Bold());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.Italic());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.Underline());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.HorizontalSeparator());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.BulletedList());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.OrderedList());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.HorizontalSeparator());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.DecreaseIndent());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.IncreaseIndent());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.HorizontalSeparator());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.InsertHR());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.InsertLink());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.RemoveLink());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.RemoveStyles());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.HorizontalSeparator());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.StrikeThrough());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.SubScript());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.SuperScript());
            AjaxControlToolkit.HTMLEditor.ToolbarButton.MethodButton btn = new                                                    AjaxControlToolkit.HTMLEditor.ToolbarButton.MethodButton();
            btn.NormalSrc = "insertimage.gif";
            btn.ID = "btnUplaodImg";
            btn.Attributes.Add("onclick", "show();");
            TopToolbar.Buttons.Add(btn);
        } 

        protected override void FillBottomToolbar()
        { 
        BottomToolbar.Buttons.Add (new AjaxControlToolkit.HTMLEditor.ToolbarButton.DesignMode());
        BottomToolbar.Buttons.Add (new AjaxControlToolkit.HTMLEditor.ToolbarButton.PreviewMode());
        } 
    }
}
