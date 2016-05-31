﻿namespace Microsoft.NodejsTools.Options {
    partial class NodejsIntellisenseOptionsControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolTip toolTip;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NodejsIntellisenseOptionsControl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this._intelliSenseModeDropdown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this._analysisPreviewFeedbackLinkLabel = new System.Windows.Forms.LinkLabel();
            this._es5DeprecatedWarning = new System.Windows.Forms.Label();
            this._intelliSenseAdvancedOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._nodejsES5IntelliSenseOptionsControl = new Microsoft.NodejsTools.Options.NodeLsIntellisenseOptionsControl();
            this._salsaLsIntellisenseOptionsControl = new Microsoft.NodejsTools.Options.SalsaLsIntellisenseOptionsControl();
            toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this._intelliSenseAdvancedOptionsGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._intelliSenseAdvancedOptionsGroupBox, 0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel6
            // 
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.Controls.Add(this._intelliSenseModeDropdown, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this._analysisPreviewFeedbackLinkLabel, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this._es5DeprecatedWarning, 1, 1);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // _intelliSenseModeDropdown
            // 
            this._intelliSenseModeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._intelliSenseModeDropdown.FormattingEnabled = true;
            this._intelliSenseModeDropdown.Items.AddRange(new object[] {
            resources.GetString("_intelliSenseModeDropdown.Items"),
            resources.GetString("_intelliSenseModeDropdown.Items1")});
            resources.ApplyResources(this._intelliSenseModeDropdown, "_intelliSenseModeDropdown");
            this._intelliSenseModeDropdown.Name = "_intelliSenseModeDropdown";
            this._intelliSenseModeDropdown.SelectedValueChanged += new System.EventHandler(this._intelliSenseModeDropdown_SelectedValueChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // _analysisPreviewFeedbackLinkLabel
            // 
            resources.ApplyResources(this._analysisPreviewFeedbackLinkLabel, "_analysisPreviewFeedbackLinkLabel");
            this._analysisPreviewFeedbackLinkLabel.Name = "_analysisPreviewFeedbackLinkLabel";
            this._analysisPreviewFeedbackLinkLabel.TabStop = true;
            this._analysisPreviewFeedbackLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._analysisPreviewFeedbackLinkLabel_LinkClicked);
            // 
            // _es5DeprecatedWarning
            // 
            resources.ApplyResources(this._es5DeprecatedWarning, "_es5DeprecatedWarning");
            this._es5DeprecatedWarning.Name = "_es5DeprecatedWarning";
            // 
            // _intelliSenseAdvancedOptionsGroupBox
            // 
            resources.ApplyResources(this._intelliSenseAdvancedOptionsGroupBox, "_intelliSenseAdvancedOptionsGroupBox");
            this._intelliSenseAdvancedOptionsGroupBox.Controls.Add(this.tableLayoutPanel2);
            this._intelliSenseAdvancedOptionsGroupBox.Name = "_intelliSenseAdvancedOptionsGroupBox";
            this._intelliSenseAdvancedOptionsGroupBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this._nodejsES5IntelliSenseOptionsControl, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this._salsaLsIntellisenseOptionsControl, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // _nodejsES5IntelliSenseOptionsControl
            // 
            resources.ApplyResources(this._nodejsES5IntelliSenseOptionsControl, "_nodejsES5IntelliSenseOptionsControl");
            this._nodejsES5IntelliSenseOptionsControl.Name = "_nodejsES5IntelliSenseOptionsControl";
            // 
            // _salsaLsIntellisenseOptionsControl
            // 
            resources.ApplyResources(this._salsaLsIntellisenseOptionsControl, "_salsaLsIntellisenseOptionsControl");
            this._salsaLsIntellisenseOptionsControl.Name = "_salsaLsIntellisenseOptionsControl";
            // 
            // NodejsIntellisenseOptionsControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NodejsIntellisenseOptionsControl";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this._intelliSenseAdvancedOptionsGroupBox.ResumeLayout(false);
            this._intelliSenseAdvancedOptionsGroupBox.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ComboBox _intelliSenseModeDropdown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel _analysisPreviewFeedbackLinkLabel;
        private System.Windows.Forms.Label _es5DeprecatedWarning;
        private System.Windows.Forms.GroupBox _intelliSenseAdvancedOptionsGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private SalsaLsIntellisenseOptionsControl _salsaLsIntellisenseOptionsControl;
        private NodeLsIntellisenseOptionsControl _nodejsES5IntelliSenseOptionsControl;
    }
}
