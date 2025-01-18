﻿using System;
using System.Collections.Generic;
using System.Text;
using Decal.Adapter;
using Decal.Adapter.Wrappers;
using MyClasses.MetaViewWrappers;
using VirindiViewService;
using VirindiViewService.Controls;

namespace AceCreator
{
    public partial class AceCreator : PluginBase
    {

        
        public HudTextBox TextboxNudgeValueCustom { get; set; }
        public HudButton ButtonNudgeN { get; set; }

        public HudButton ButtonNudgeNE { get; set; }
        public HudButton ButtonNudgeE { get; set; }
        public HudButton ButtonNudgeSE { get; set; }

        public HudButton ButtonNudgeS { get; set; }

        public HudButton ButtonNudgeSW { get; set; }
        public HudButton ButtonNudgeW { get; set; }
        public HudButton ButtonNudgeNW { get; set; }

        public HudButton ButtonNudgeUp { get; set; }
        public HudButton ButtonNudgeDown { get; set; }

        public HudButton ButtonRotateN { get; set; }
        public HudButton ButtonRotateE { get; set; }
        public HudButton ButtonRotateS { get; set; }
        public HudButton ButtonRotateW { get; set; }

        public HudButton ButtonRotateNE { get; set; }
        public HudButton ButtonRotateSE { get; set; }
        public HudButton ButtonRotateSW { get; set; }
        public HudButton ButtonRotateNW { get; set; }

        public HudButton ButtonFreeRotate { get; set; }

        public HudButton ButtonNudgeHere { get; set; }
        public HudButton ButtonRotateHere { get; set; }
        public HudButton ButtonNudgeValueInc { get; set; }
        public HudButton ButtonNudgeValueDec { get; set; }
        public HudButton ButtonNudgeValueLargeInc { get; set; }
        public HudButton ButtonNudgeValueLargeDec { get; set; }
        public HudButton ButtonNudgeValueReset { get; set; }



        public HudTextBox TextboxFreeRotate { get; set; }

        // Button Events
        public void ButtonNudgeN_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.ButtonCommand = "/nudge n " + TextboxNudgeValueCustom.Text;
                CommandWait(sender, e);

            }
            catch (Exception ex) { Util.LogError(ex); }
        }
        public void ButtonNudgeNE_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.ButtonCommand = "/nudge ne " + TextboxNudgeValueCustom.Text;
                CommandWait(sender, e);
            }
            catch (Exception ex) { Util.LogError(ex); }
        }
        public void ButtonNudgeE_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.ButtonCommand = "/nudge e " + TextboxNudgeValueCustom.Text;
                CommandWait(sender, e);
            }
            catch (Exception ex) { Util.LogError(ex); }
        }
        public void ButtonNudgeSE_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.ButtonCommand = "/nudge se " + TextboxNudgeValueCustom.Text;
                CommandWait(sender, e);
            }
            catch (Exception ex) { Util.LogError(ex); }
        }
        public void ButtonNudgeS_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.ButtonCommand = "/nudge s " + TextboxNudgeValueCustom.Text;
                CommandWait(sender, e);
            }
            catch (Exception ex) { Util.LogError(ex); }
        }
        public void ButtonNudgeSW_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.ButtonCommand = "/nudge sw " + TextboxNudgeValueCustom.Text;
                CommandWait(sender, e);
            }
            catch (Exception ex) { Util.LogError(ex); }
        }
        public void ButtonNudgeW_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.ButtonCommand = "/nudge w " + TextboxNudgeValueCustom.Text;
                CommandWait(sender, e);
            }
            catch (Exception ex) { Util.LogError(ex); }
        }
        public void ButtonNudgeNW_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.ButtonCommand = "/nudge nw " + TextboxNudgeValueCustom.Text;
                CommandWait(sender, e);
            }
            catch (Exception ex) { Util.LogError(ex); }
        }
        //Rotate
        public void ButtonRotateN_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.ButtonCommand = "/rotate n";
                CommandWait(sender, e);
            }
            catch (Exception ex) { Util.LogError(ex); }
        }
        public void ButtonRotateE_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.ButtonCommand = "/rotate e";
                CommandWait(sender, e);
            }
            catch (Exception ex) { Util.LogError(ex); }
        }

        public void ButtonRotateS_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.ButtonCommand = "/rotate s";
                CommandWait(sender, e);
            }
            catch (Exception ex) { Util.LogError(ex); }
        }

        public void ButtonRotateW_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.ButtonCommand = "/rotate w";
                CommandWait(sender, e);
            }
            catch (Exception ex) { Util.LogError(ex); }
        }

        public void ButtonRotateNE_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.ButtonCommand = "/rotate ne";
                CommandWait(sender, e);
            }
            catch (Exception ex) { Util.LogError(ex); }
        }
        public void ButtonRotateSE_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.ButtonCommand = "/rotate se";
                CommandWait(sender, e);
            }
            catch (Exception ex) { Util.LogError(ex); }
        }
        public void ButtonRotateSW_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.ButtonCommand = "/rotate sw";
                CommandWait(sender, e);
            }
            catch (Exception ex) { Util.LogError(ex); }
        }
        public void ButtonRotateNW_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.ButtonCommand = "/rotate nw";
                CommandWait(sender, e);
            }
            catch (Exception ex) { Util.LogError(ex); }
        }

        public void ButtonFreeRotate_Click(object sender, EventArgs e)
        {
            try
            {
                double tempRotateValue;
                double finalRotateValue = 0;
                double.TryParse(TextboxFreeRotate.Text, out tempRotateValue);

                if (tempRotateValue > 360)
                {
                    Util.WriteToChat("Rotate Value is above 360");
                    return;
                }

                else
                    finalRotateValue = 360 - tempRotateValue;


                Globals.ButtonCommand = "/rotate " + finalRotateValue;

                CommandWait(sender, e);

            }
            catch (Exception ex) { Util.LogError(ex); }
        }

        public void ButtonNudgeUp_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.ButtonCommand = "/nudge up " + TextboxNudgeValueCustom.Text;
                CommandWait(sender, e);

            }
            catch (Exception ex) { Util.LogError(ex); }
        }
        public void ButtonNudgeDown_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.ButtonCommand = "/nudge down " + TextboxNudgeValueCustom.Text;
                CommandWait(sender, e);

            }
            catch (Exception ex) { Util.LogError(ex); }
        }
        public void ButtonNudgeHere_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.ButtonCommand = "/nudge here";
                CommandWait(sender, e);
            }
            catch (Exception ex) { Util.LogError(ex); }
        }

        public void ButtonRotateHere_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.ButtonCommand = "/rotate here";
                CommandWait(sender, e);
            }
            catch (Exception ex) { Util.LogError(ex); }
        }

        public void ButtonNudgeValueInc_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(TextboxNudgeValueCustom.Text, out var value))
                {
                    if (value < 0.1)
                        TextboxNudgeValueCustom.Text = $"{value + 0.01}";
                    else
                        TextboxNudgeValueCustom.Text = $"{value + 0.1}";
                }
                else
                    TextboxNudgeValueCustom.Text = "0.5";
            }
            catch (Exception ex) { Util.LogError(ex); }
        }

        public void ButtonNudgeValueDec_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(TextboxNudgeValueCustom.Text, out var value))
                {
                    if(value > 0.01 && value <= 0.1)
                        TextboxNudgeValueCustom.Text = $"{value - 0.01}";
                    else if(value > 0.1)
                        TextboxNudgeValueCustom.Text = $"{value - 0.1}";
                }
                else
                    TextboxNudgeValueCustom.Text = "0.5";
            }
            catch (Exception ex) { Util.LogError(ex); }
        }

        public void ButtonNudgeValueLargeInc_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(TextboxNudgeValueCustom.Text, out var value))
                {
                    if (value < 0.1)
                        TextboxNudgeValueCustom.Text = $"0.5";
                    else
                        TextboxNudgeValueCustom.Text = $"{value + 0.5}";
                }
                else
                    TextboxNudgeValueCustom.Text = "0.5";
            }
            catch (Exception ex) { Util.LogError(ex); }
        }

        public void ButtonNudgeValueLargeDec_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(TextboxNudgeValueCustom.Text, out var value))
                {
                    if (value > 0.5)
                        TextboxNudgeValueCustom.Text = $"{value - 0.5}";
                }
                else
                    TextboxNudgeValueCustom.Text = "0.5";
            }
            catch (Exception ex) { Util.LogError(ex); }
        }

        public void ButtonNudgeValueReset_Click(object sender, EventArgs e)
        {
            try
            {
                TextboxNudgeValueCustom.Text = "0.5";
            }
            catch (Exception ex) { Util.LogError(ex); }
        }

        public void CommandWait(object sender, EventArgs e)
        {
            try
            {                
                WO = CoreManager.Current.WorldFilter[CoreManager.Current.Actions.CurrentSelection];
                aceItem.name = WO.Name;
                aceItem.id = WO.Id;

                Globals.Host.Actions.RequestId(Globals.Host.Actions.CurrentSelection);
                CoreManager.Current.WorldFilter.ChangeObject += WaitForItemUpdate;
            }
            catch (Exception ex) { Util.LogError(ex); }
        }
    }
}
