﻿using System.Windows.Forms;

namespace AutoScreenCapture
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButtonStartScreenCapture = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButtonStopScreenCapture = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButtonKeyboardShortcuts = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButtonHelp = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlViews = new System.Windows.Forms.TabControl();
            this.contextMenuStripScreenshot = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listBoxScreenshots = new System.Windows.Forms.ListBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripSystemTrayIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorAbout = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemStartScreenCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStopScreenCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemScreenCaptureStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorScreenCapture = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemShowHideInterface = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorInterface = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddRegion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddMacroTag = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAddTrigger = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemChange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemChangeScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemChangeRegion = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemChangeEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemChangeSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemChangeMacroTag = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemChangeTrigger = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEmailSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFileTransferSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDynamicRegexValidator = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorTools = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCaptureNowArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCaptureNowEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorCaptureNow = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemRegionSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRegionSelectOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorRegionSelectOptions = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemRegionSelectClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRegionSelectClipboardAutoSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRegionSelectClipboardAutoSaveEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFloatingScreenshot = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorRegionSelect = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemApplyLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorApplyLabel = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlModules = new System.Windows.Forms.TabControl();
            this.tabPageSetup = new System.Windows.Forms.TabPage();
            this.groupBoxApplicationFocus = new System.Windows.Forms.GroupBox();
            this.numericUpDownApplicationFocusDelayAfter = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownApplicationFocusDelayBefore = new System.Windows.Forms.NumericUpDown();
            this.labelApplicationFocusDelayAfter = new System.Windows.Forms.Label();
            this.labelApplicationFocusDelayBefore = new System.Windows.Forms.Label();
            this.buttonApplicationFocusTest = new System.Windows.Forms.Button();
            this.buttonApplicationFocusRefresh = new System.Windows.Forms.Button();
            this.comboBoxProcessList = new System.Windows.Forms.ComboBox();
            this.groupBoxActiveWindowTitle = new System.Windows.Forms.GroupBox();
            this.checkBoxActiveWindowTitleComparisonCheckReverse = new System.Windows.Forms.CheckBox();
            this.buttonDynamicRegexValidator = new System.Windows.Forms.Button();
            this.radioButtonRegularExpressionMatch = new System.Windows.Forms.RadioButton();
            this.radioButtonCaseSensitiveMatch = new System.Windows.Forms.RadioButton();
            this.radioButtonCaseInsensitiveMatch = new System.Windows.Forms.RadioButton();
            this.textBoxActiveWindowTitle = new System.Windows.Forms.TextBox();
            this.checkBoxActiveWindowTitleComparisonCheck = new System.Windows.Forms.CheckBox();
            this.groupBoxSecurity = new System.Windows.Forms.GroupBox();
            this.labelPasswordDescription = new System.Windows.Forms.Label();
            this.buttonSetPassphrase = new System.Windows.Forms.Button();
            this.textBoxPassphrase = new System.Windows.Forms.TextBox();
            this.checkBoxScreenshotLabel = new System.Windows.Forms.CheckBox();
            this.comboBoxScreenshotLabel = new System.Windows.Forms.ComboBox();
            this.groupBoxCaptureDelay = new System.Windows.Forms.GroupBox();
            this.labelLimit = new System.Windows.Forms.Label();
            this.checkBoxInitialScreenshot = new System.Windows.Forms.CheckBox();
            this.numericUpDownCaptureLimit = new System.Windows.Forms.NumericUpDown();
            this.checkBoxCaptureLimit = new System.Windows.Forms.CheckBox();
            this.labelMillisecondsInterval = new System.Windows.Forms.Label();
            this.numericUpDownMillisecondsInterval = new System.Windows.Forms.NumericUpDown();
            this.labelSecondsInterval = new System.Windows.Forms.Label();
            this.labelMinutesInterval = new System.Windows.Forms.Label();
            this.labelHoursInterval = new System.Windows.Forms.Label();
            this.numericUpDownSecondsInterval = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinutesInterval = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHoursInterval = new System.Windows.Forms.NumericUpDown();
            this.tabPageScreenshots = new System.Windows.Forms.TabPage();
            this.tabPageScreens = new System.Windows.Forms.TabPage();
            this.tabPageRegions = new System.Windows.Forms.TabPage();
            this.tabPageEditors = new System.Windows.Forms.TabPage();
            this.tabPageSchedules = new System.Windows.Forms.TabPage();
            this.tabPageMacroTags = new System.Windows.Forms.TabPage();
            this.tabPageTriggers = new System.Windows.Forms.TabPage();
            this.timerScheduledCapture = new System.Windows.Forms.Timer(this.components);
            this.timerScreenCapture = new System.Windows.Forms.Timer(this.components);
            this.comboBoxFilterValue = new System.Windows.Forms.ComboBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.buttonRefreshFilterValues = new System.Windows.Forms.Button();
            this.comboBoxFilterType = new System.Windows.Forms.ComboBox();
            this.timerPerformMaintenance = new System.Windows.Forms.Timer(this.components);
            this.labelHelp = new System.Windows.Forms.Label();
            this.timerShowNextHelpTip = new System.Windows.Forms.Timer(this.components);
            this.statusStrip.SuspendLayout();
            this.contextMenuStripSystemTrayIcon.SuspendLayout();
            this.tabControlModules.SuspendLayout();
            this.tabPageSetup.SuspendLayout();
            this.groupBoxApplicationFocus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownApplicationFocusDelayAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownApplicationFocusDelayBefore)).BeginInit();
            this.groupBoxActiveWindowTitle.SuspendLayout();
            this.groupBoxSecurity.SuspendLayout();
            this.groupBoxCaptureDelay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCaptureLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMillisecondsInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondsInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutesInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoursInterval)).BeginInit();
            this.tabPageScreenshots.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(0, 56);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowWeekNumbers = true;
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.TabStop = false;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.DateSelected_monthCalendar);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButtonStartScreenCapture,
            this.toolStripSplitButtonStopScreenCapture,
            this.toolStripSplitButtonKeyboardShortcuts,
            this.toolStripSplitButtonHelp,
            this.toolStripInfo});
            this.statusStrip.Location = new System.Drawing.Point(0, 633);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(1040, 22);
            this.statusStrip.TabIndex = 3;
            // 
            // toolStripSplitButtonStartScreenCapture
            // 
            this.toolStripSplitButtonStartScreenCapture.AutoToolTip = false;
            this.toolStripSplitButtonStartScreenCapture.DropDownButtonWidth = 0;
            this.toolStripSplitButtonStartScreenCapture.Enabled = false;
            this.toolStripSplitButtonStartScreenCapture.Image = global::AutoScreenCapture.Properties.Resources.start_screen_capture;
            this.toolStripSplitButtonStartScreenCapture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripSplitButtonStartScreenCapture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonStartScreenCapture.Name = "toolStripSplitButtonStartScreenCapture";
            this.toolStripSplitButtonStartScreenCapture.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripSplitButtonStartScreenCapture.Size = new System.Drawing.Size(135, 20);
            this.toolStripSplitButtonStartScreenCapture.Text = "Start Screen Capture";
            this.toolStripSplitButtonStartScreenCapture.ButtonClick += new System.EventHandler(this.toolStripMenuItemStartScreenCapture_Click);
            // 
            // toolStripSplitButtonStopScreenCapture
            // 
            this.toolStripSplitButtonStopScreenCapture.AutoToolTip = false;
            this.toolStripSplitButtonStopScreenCapture.DropDownButtonWidth = 0;
            this.toolStripSplitButtonStopScreenCapture.Enabled = false;
            this.toolStripSplitButtonStopScreenCapture.Image = global::AutoScreenCapture.Properties.Resources.stop_screen_capture;
            this.toolStripSplitButtonStopScreenCapture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripSplitButtonStopScreenCapture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonStopScreenCapture.Name = "toolStripSplitButtonStopScreenCapture";
            this.toolStripSplitButtonStopScreenCapture.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripSplitButtonStopScreenCapture.Size = new System.Drawing.Size(135, 20);
            this.toolStripSplitButtonStopScreenCapture.Text = "Stop Screen Capture";
            this.toolStripSplitButtonStopScreenCapture.ButtonClick += new System.EventHandler(this.toolStripMenuItemStopScreenCapture_Click);
            // 
            // toolStripSplitButtonKeyboardShortcuts
            // 
            this.toolStripSplitButtonKeyboardShortcuts.AutoToolTip = false;
            this.toolStripSplitButtonKeyboardShortcuts.DropDownButtonWidth = 0;
            this.toolStripSplitButtonKeyboardShortcuts.Image = global::AutoScreenCapture.Properties.Resources.keyboard;
            this.toolStripSplitButtonKeyboardShortcuts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripSplitButtonKeyboardShortcuts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonKeyboardShortcuts.Name = "toolStripSplitButtonKeyboardShortcuts";
            this.toolStripSplitButtonKeyboardShortcuts.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripSplitButtonKeyboardShortcuts.Size = new System.Drawing.Size(131, 20);
            this.toolStripSplitButtonKeyboardShortcuts.Text = "Keyboard Shortcuts";
            this.toolStripSplitButtonKeyboardShortcuts.ButtonClick += new System.EventHandler(this.toolStripSplitButtonKeyboardShortcuts_ButtonClick);
            // 
            // toolStripSplitButtonHelp
            // 
            this.toolStripSplitButtonHelp.DropDownButtonWidth = 0;
            this.toolStripSplitButtonHelp.Image = global::AutoScreenCapture.Properties.Resources.help;
            this.toolStripSplitButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonHelp.Name = "toolStripSplitButtonHelp";
            this.toolStripSplitButtonHelp.Size = new System.Drawing.Size(53, 20);
            this.toolStripSplitButtonHelp.Text = "Help";
            this.toolStripSplitButtonHelp.ToolTipText = "Help";
            this.toolStripSplitButtonHelp.ButtonClick += new System.EventHandler(this.toolStripSplitButtonHelp_ButtonClick);
            // 
            // toolStripInfo
            // 
            this.toolStripInfo.AutoSize = false;
            this.toolStripInfo.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripInfo.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)));
            this.toolStripInfo.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.toolStripInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripInfo.Name = "toolStripInfo";
            this.toolStripInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripInfo.Size = new System.Drawing.Size(571, 17);
            this.toolStripInfo.Spring = true;
            this.toolStripInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tabControlViews
            // 
            this.tabControlViews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlViews.Location = new System.Drawing.Point(251, 27);
            this.tabControlViews.Name = "tabControlViews";
            this.tabControlViews.SelectedIndex = 0;
            this.tabControlViews.Size = new System.Drawing.Size(789, 600);
            this.tabControlViews.TabIndex = 0;
            this.tabControlViews.TabStop = false;
            this.tabControlViews.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlViews_Selected);
            // 
            // contextMenuStripScreenshot
            // 
            this.contextMenuStripScreenshot.Name = "contextMenuStripScreenshotPreview";
            this.contextMenuStripScreenshot.Size = new System.Drawing.Size(61, 4);
            // 
            // listBoxScreenshots
            // 
            this.listBoxScreenshots.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxScreenshots.FormattingEnabled = true;
            this.listBoxScreenshots.HorizontalScrollbar = true;
            this.listBoxScreenshots.IntegralHeight = false;
            this.listBoxScreenshots.Location = new System.Drawing.Point(3, 3);
            this.listBoxScreenshots.Name = "listBoxScreenshots";
            this.listBoxScreenshots.ScrollAlwaysVisible = true;
            this.listBoxScreenshots.Size = new System.Drawing.Size(235, 357);
            this.listBoxScreenshots.TabIndex = 0;
            this.listBoxScreenshots.TabStop = false;
            this.listBoxScreenshots.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged_listBoxScreenshots);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStripSystemTrayIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // contextMenuStripSystemTrayIcon
            // 
            this.contextMenuStripSystemTrayIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAbout,
            this.toolStripSeparatorAbout,
            this.toolStripMenuItemStartScreenCapture,
            this.toolStripMenuItemStopScreenCapture,
            this.toolStripMenuItemScreenCaptureStatus,
            this.toolStripSeparatorScreenCapture,
            this.toolStripMenuItemShowHideInterface,
            this.toolStripSeparatorInterface,
            this.toolStripMenuItemAdd,
            this.toolStripMenuItemChange,
            this.toolStripMenuItemSettings,
            this.toolStripMenuItemTools,
            this.toolStripSeparatorTools,
            this.toolStripMenuItemCaptureNowArchive,
            this.toolStripMenuItemCaptureNowEdit,
            this.toolStripSeparatorCaptureNow,
            this.toolStripMenuItemRegionSelect,
            this.toolStripSeparatorRegionSelect,
            this.toolStripMenuItemApplyLabel,
            this.toolStripSeparatorApplyLabel,
            this.toolStripMenuItemExit});
            this.contextMenuStripSystemTrayIcon.Name = "contextMenuStrip";
            this.contextMenuStripSystemTrayIcon.Size = new System.Drawing.Size(220, 354);
            this.contextMenuStripSystemTrayIcon.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripSystemTrayIcon_Opening);
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Image = global::AutoScreenCapture.Properties.Resources.about;
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(219, 22);
            this.toolStripMenuItemAbout.Text = "About Auto Screen Capture";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // toolStripSeparatorAbout
            // 
            this.toolStripSeparatorAbout.Name = "toolStripSeparatorAbout";
            this.toolStripSeparatorAbout.Size = new System.Drawing.Size(216, 6);
            // 
            // toolStripMenuItemStartScreenCapture
            // 
            this.toolStripMenuItemStartScreenCapture.Image = global::AutoScreenCapture.Properties.Resources.start_screen_capture;
            this.toolStripMenuItemStartScreenCapture.Name = "toolStripMenuItemStartScreenCapture";
            this.toolStripMenuItemStartScreenCapture.Size = new System.Drawing.Size(219, 22);
            this.toolStripMenuItemStartScreenCapture.Text = "Start Screen Capture";
            this.toolStripMenuItemStartScreenCapture.Click += new System.EventHandler(this.toolStripMenuItemStartScreenCapture_Click);
            // 
            // toolStripMenuItemStopScreenCapture
            // 
            this.toolStripMenuItemStopScreenCapture.Enabled = false;
            this.toolStripMenuItemStopScreenCapture.Image = global::AutoScreenCapture.Properties.Resources.stop_screen_capture;
            this.toolStripMenuItemStopScreenCapture.Name = "toolStripMenuItemStopScreenCapture";
            this.toolStripMenuItemStopScreenCapture.Size = new System.Drawing.Size(219, 22);
            this.toolStripMenuItemStopScreenCapture.Text = "Stop Screen Capture";
            this.toolStripMenuItemStopScreenCapture.Click += new System.EventHandler(this.toolStripMenuItemStopScreenCapture_Click);
            // 
            // toolStripMenuItemScreenCaptureStatus
            // 
            this.toolStripMenuItemScreenCaptureStatus.Name = "toolStripMenuItemScreenCaptureStatus";
            this.toolStripMenuItemScreenCaptureStatus.Size = new System.Drawing.Size(219, 22);
            this.toolStripMenuItemScreenCaptureStatus.Text = "Screen Capture Status";
            this.toolStripMenuItemScreenCaptureStatus.Click += new System.EventHandler(this.toolStripMenuItemScreenCaptureStatus_Click);
            // 
            // toolStripSeparatorScreenCapture
            // 
            this.toolStripSeparatorScreenCapture.Name = "toolStripSeparatorScreenCapture";
            this.toolStripSeparatorScreenCapture.Size = new System.Drawing.Size(216, 6);
            // 
            // toolStripMenuItemShowHideInterface
            // 
            this.toolStripMenuItemShowHideInterface.Name = "toolStripMenuItemShowHideInterface";
            this.toolStripMenuItemShowHideInterface.Size = new System.Drawing.Size(219, 22);
            this.toolStripMenuItemShowHideInterface.Text = "Show/Hide Interface";
            this.toolStripMenuItemShowHideInterface.Click += new System.EventHandler(this.toolStripMenuItemShowHideInterface_Click);
            // 
            // toolStripSeparatorInterface
            // 
            this.toolStripSeparatorInterface.Name = "toolStripSeparatorInterface";
            this.toolStripSeparatorInterface.Size = new System.Drawing.Size(216, 6);
            // 
            // toolStripMenuItemAdd
            // 
            this.toolStripMenuItemAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddScreen,
            this.toolStripMenuItemAddRegion,
            this.toolStripMenuItemAddEditor,
            this.toolStripMenuItemAddSchedule,
            this.toolStripMenuItemAddMacroTag,
            this.toolStripMenuItemAddTrigger});
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.Size = new System.Drawing.Size(219, 22);
            this.toolStripMenuItemAdd.Text = "Add";
            // 
            // toolStripMenuItemAddScreen
            // 
            this.toolStripMenuItemAddScreen.Image = global::AutoScreenCapture.Properties.Resources.screen;
            this.toolStripMenuItemAddScreen.Name = "toolStripMenuItemAddScreen";
            this.toolStripMenuItemAddScreen.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItemAddScreen.Text = "Screen";
            this.toolStripMenuItemAddScreen.Click += new System.EventHandler(this.addScreen_Click);
            // 
            // toolStripMenuItemAddRegion
            // 
            this.toolStripMenuItemAddRegion.Image = global::AutoScreenCapture.Properties.Resources.region;
            this.toolStripMenuItemAddRegion.Name = "toolStripMenuItemAddRegion";
            this.toolStripMenuItemAddRegion.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItemAddRegion.Text = "Region";
            this.toolStripMenuItemAddRegion.Click += new System.EventHandler(this.addRegion_Click);
            // 
            // toolStripMenuItemAddEditor
            // 
            this.toolStripMenuItemAddEditor.Image = global::AutoScreenCapture.Properties.Resources.edit;
            this.toolStripMenuItemAddEditor.Name = "toolStripMenuItemAddEditor";
            this.toolStripMenuItemAddEditor.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItemAddEditor.Text = "Editor";
            this.toolStripMenuItemAddEditor.Click += new System.EventHandler(this.addEditor_Click);
            // 
            // toolStripMenuItemAddSchedule
            // 
            this.toolStripMenuItemAddSchedule.Image = global::AutoScreenCapture.Properties.Resources.schedule;
            this.toolStripMenuItemAddSchedule.Name = "toolStripMenuItemAddSchedule";
            this.toolStripMenuItemAddSchedule.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItemAddSchedule.Text = "Schedule";
            this.toolStripMenuItemAddSchedule.Click += new System.EventHandler(this.addSchedule_Click);
            // 
            // toolStripMenuItemAddMacroTag
            // 
            this.toolStripMenuItemAddMacroTag.Image = global::AutoScreenCapture.Properties.Resources.brick;
            this.toolStripMenuItemAddMacroTag.Name = "toolStripMenuItemAddMacroTag";
            this.toolStripMenuItemAddMacroTag.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItemAddMacroTag.Text = "Macro Tag";
            this.toolStripMenuItemAddMacroTag.Click += new System.EventHandler(this.addMacroTag_Click);
            // 
            // toolStripMenuItemAddTrigger
            // 
            this.toolStripMenuItemAddTrigger.Image = global::AutoScreenCapture.Properties.Resources.trigger;
            this.toolStripMenuItemAddTrigger.Name = "toolStripMenuItemAddTrigger";
            this.toolStripMenuItemAddTrigger.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItemAddTrigger.Text = "Trigger";
            this.toolStripMenuItemAddTrigger.Click += new System.EventHandler(this.addTrigger_Click);
            // 
            // toolStripMenuItemChange
            // 
            this.toolStripMenuItemChange.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemChangeScreen,
            this.toolStripMenuItemChangeRegion,
            this.toolStripMenuItemChangeEditor,
            this.toolStripMenuItemChangeSchedule,
            this.toolStripMenuItemChangeMacroTag,
            this.toolStripMenuItemChangeTrigger});
            this.toolStripMenuItemChange.Name = "toolStripMenuItemChange";
            this.toolStripMenuItemChange.Size = new System.Drawing.Size(219, 22);
            this.toolStripMenuItemChange.Text = "Change";
            // 
            // toolStripMenuItemChangeScreen
            // 
            this.toolStripMenuItemChangeScreen.Image = global::AutoScreenCapture.Properties.Resources.screen;
            this.toolStripMenuItemChangeScreen.Name = "toolStripMenuItemChangeScreen";
            this.toolStripMenuItemChangeScreen.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItemChangeScreen.Text = "Screen";
            // 
            // toolStripMenuItemChangeRegion
            // 
            this.toolStripMenuItemChangeRegion.Image = global::AutoScreenCapture.Properties.Resources.region;
            this.toolStripMenuItemChangeRegion.Name = "toolStripMenuItemChangeRegion";
            this.toolStripMenuItemChangeRegion.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItemChangeRegion.Text = "Region";
            // 
            // toolStripMenuItemChangeEditor
            // 
            this.toolStripMenuItemChangeEditor.Image = global::AutoScreenCapture.Properties.Resources.edit;
            this.toolStripMenuItemChangeEditor.Name = "toolStripMenuItemChangeEditor";
            this.toolStripMenuItemChangeEditor.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItemChangeEditor.Text = "Editor";
            // 
            // toolStripMenuItemChangeSchedule
            // 
            this.toolStripMenuItemChangeSchedule.Image = global::AutoScreenCapture.Properties.Resources.schedule;
            this.toolStripMenuItemChangeSchedule.Name = "toolStripMenuItemChangeSchedule";
            this.toolStripMenuItemChangeSchedule.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItemChangeSchedule.Text = "Schedule";
            // 
            // toolStripMenuItemChangeMacroTag
            // 
            this.toolStripMenuItemChangeMacroTag.Image = global::AutoScreenCapture.Properties.Resources.brick;
            this.toolStripMenuItemChangeMacroTag.Name = "toolStripMenuItemChangeMacroTag";
            this.toolStripMenuItemChangeMacroTag.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItemChangeMacroTag.Text = "Macro Tag";
            // 
            // toolStripMenuItemChangeTrigger
            // 
            this.toolStripMenuItemChangeTrigger.Image = global::AutoScreenCapture.Properties.Resources.trigger;
            this.toolStripMenuItemChangeTrigger.Name = "toolStripMenuItemChangeTrigger";
            this.toolStripMenuItemChangeTrigger.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItemChangeTrigger.Text = "Trigger";
            // 
            // toolStripMenuItemSettings
            // 
            this.toolStripMenuItemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEmailSettings,
            this.toolStripMenuItemFileTransferSettings});
            this.toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            this.toolStripMenuItemSettings.Size = new System.Drawing.Size(219, 22);
            this.toolStripMenuItemSettings.Text = "Settings";
            // 
            // toolStripMenuItemEmailSettings
            // 
            this.toolStripMenuItemEmailSettings.Image = global::AutoScreenCapture.Properties.Resources.email;
            this.toolStripMenuItemEmailSettings.Name = "toolStripMenuItemEmailSettings";
            this.toolStripMenuItemEmailSettings.Size = new System.Drawing.Size(182, 22);
            this.toolStripMenuItemEmailSettings.Text = "Email Settings";
            this.toolStripMenuItemEmailSettings.Visible = false;
            this.toolStripMenuItemEmailSettings.Click += new System.EventHandler(this.toolStripMenuItemEmailSettings_Click);
            // 
            // toolStripMenuItemFileTransferSettings
            // 
            this.toolStripMenuItemFileTransferSettings.Image = global::AutoScreenCapture.Properties.Resources.file_transfer;
            this.toolStripMenuItemFileTransferSettings.Name = "toolStripMenuItemFileTransferSettings";
            this.toolStripMenuItemFileTransferSettings.Size = new System.Drawing.Size(182, 22);
            this.toolStripMenuItemFileTransferSettings.Text = "File Transfer Settings";
            this.toolStripMenuItemFileTransferSettings.Visible = false;
            this.toolStripMenuItemFileTransferSettings.Click += new System.EventHandler(this.toolStripMenuItemFileTransferSettings_Click);
            // 
            // toolStripMenuItemTools
            // 
            this.toolStripMenuItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDynamicRegexValidator});
            this.toolStripMenuItemTools.Name = "toolStripMenuItemTools";
            this.toolStripMenuItemTools.Size = new System.Drawing.Size(219, 22);
            this.toolStripMenuItemTools.Text = "Tools";
            // 
            // toolStripMenuItemDynamicRegexValidator
            // 
            this.toolStripMenuItemDynamicRegexValidator.Name = "toolStripMenuItemDynamicRegexValidator";
            this.toolStripMenuItemDynamicRegexValidator.Size = new System.Drawing.Size(204, 22);
            this.toolStripMenuItemDynamicRegexValidator.Text = "Dynamic Regex Validator";
            this.toolStripMenuItemDynamicRegexValidator.Click += new System.EventHandler(this.toolStripMenuItemDynamicRegexValidator_Click);
            // 
            // toolStripSeparatorTools
            // 
            this.toolStripSeparatorTools.Name = "toolStripSeparatorTools";
            this.toolStripSeparatorTools.Size = new System.Drawing.Size(216, 6);
            // 
            // toolStripMenuItemCaptureNowArchive
            // 
            this.toolStripMenuItemCaptureNowArchive.Image = global::AutoScreenCapture.Properties.Resources.capture_archive;
            this.toolStripMenuItemCaptureNowArchive.Name = "toolStripMenuItemCaptureNowArchive";
            this.toolStripMenuItemCaptureNowArchive.Size = new System.Drawing.Size(219, 22);
            this.toolStripMenuItemCaptureNowArchive.Text = "Capture Now / Archive";
            this.toolStripMenuItemCaptureNowArchive.Click += new System.EventHandler(this.toolStripMenuItemCaptureNowArchive_Click);
            // 
            // toolStripMenuItemCaptureNowEdit
            // 
            this.toolStripMenuItemCaptureNowEdit.Image = global::AutoScreenCapture.Properties.Resources.capture_edit;
            this.toolStripMenuItemCaptureNowEdit.Name = "toolStripMenuItemCaptureNowEdit";
            this.toolStripMenuItemCaptureNowEdit.Size = new System.Drawing.Size(219, 22);
            this.toolStripMenuItemCaptureNowEdit.Text = "Capture Now / Edit";
            this.toolStripMenuItemCaptureNowEdit.Click += new System.EventHandler(this.toolStripMenuItemCaptureNowEdit_Click);
            // 
            // toolStripSeparatorCaptureNow
            // 
            this.toolStripSeparatorCaptureNow.Name = "toolStripSeparatorCaptureNow";
            this.toolStripSeparatorCaptureNow.Size = new System.Drawing.Size(216, 6);
            // 
            // toolStripMenuItemRegionSelect
            // 
            this.toolStripMenuItemRegionSelect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRegionSelectOptions,
            this.toolStripSeparatorRegionSelectOptions,
            this.toolStripMenuItemRegionSelectClipboard,
            this.toolStripMenuItemRegionSelectClipboardAutoSave,
            this.toolStripMenuItemRegionSelectClipboardAutoSaveEdit,
            this.toolStripMenuItemFloatingScreenshot});
            this.toolStripMenuItemRegionSelect.Image = global::AutoScreenCapture.Properties.Resources.region;
            this.toolStripMenuItemRegionSelect.Name = "toolStripMenuItemRegionSelect";
            this.toolStripMenuItemRegionSelect.Size = new System.Drawing.Size(219, 22);
            this.toolStripMenuItemRegionSelect.Text = "Region Select";
            // 
            // toolStripMenuItemRegionSelectOptions
            // 
            this.toolStripMenuItemRegionSelectOptions.Name = "toolStripMenuItemRegionSelectOptions";
            this.toolStripMenuItemRegionSelectOptions.Size = new System.Drawing.Size(241, 22);
            this.toolStripMenuItemRegionSelectOptions.Text = "Region Select Options ...";
            this.toolStripMenuItemRegionSelectOptions.Click += new System.EventHandler(this.toolStripMenuItemRegionSelectOptions_Click);
            // 
            // toolStripSeparatorRegionSelectOptions
            // 
            this.toolStripSeparatorRegionSelectOptions.Name = "toolStripSeparatorRegionSelectOptions";
            this.toolStripSeparatorRegionSelectOptions.Size = new System.Drawing.Size(238, 6);
            // 
            // toolStripMenuItemRegionSelectClipboard
            // 
            this.toolStripMenuItemRegionSelectClipboard.Name = "toolStripMenuItemRegionSelectClipboard";
            this.toolStripMenuItemRegionSelectClipboard.Size = new System.Drawing.Size(241, 22);
            this.toolStripMenuItemRegionSelectClipboard.Text = "Clipboard";
            this.toolStripMenuItemRegionSelectClipboard.Click += new System.EventHandler(this.toolStripMenuItemRegionSelectClipboard_Click);
            // 
            // toolStripMenuItemRegionSelectClipboardAutoSave
            // 
            this.toolStripMenuItemRegionSelectClipboardAutoSave.Name = "toolStripMenuItemRegionSelectClipboardAutoSave";
            this.toolStripMenuItemRegionSelectClipboardAutoSave.Size = new System.Drawing.Size(241, 22);
            this.toolStripMenuItemRegionSelectClipboardAutoSave.Text = "Clipboard / Auto Save";
            this.toolStripMenuItemRegionSelectClipboardAutoSave.Click += new System.EventHandler(this.toolStripMenuItemRegionSelectClipboardAutoSave_Click);
            // 
            // toolStripMenuItemRegionSelectClipboardAutoSaveEdit
            // 
            this.toolStripMenuItemRegionSelectClipboardAutoSaveEdit.Name = "toolStripMenuItemRegionSelectClipboardAutoSaveEdit";
            this.toolStripMenuItemRegionSelectClipboardAutoSaveEdit.Size = new System.Drawing.Size(241, 22);
            this.toolStripMenuItemRegionSelectClipboardAutoSaveEdit.Text = "Clipboard / Auto Save / Edit";
            this.toolStripMenuItemRegionSelectClipboardAutoSaveEdit.Click += new System.EventHandler(this.toolStripMenuItemRegionSelectClipboardAutoSaveEdit_Click);
            // 
            // toolStripMenuItemFloatingScreenshot
            // 
            this.toolStripMenuItemFloatingScreenshot.Name = "toolStripMenuItemFloatingScreenshot";
            this.toolStripMenuItemFloatingScreenshot.Size = new System.Drawing.Size(241, 22);
            this.toolStripMenuItemFloatingScreenshot.Text = "Clipboard / Floating Screenshot";
            this.toolStripMenuItemFloatingScreenshot.Click += new System.EventHandler(this.toolStripMenuItemRegionSelectClipboardFloatingScreenshot_Click);
            // 
            // toolStripSeparatorRegionSelect
            // 
            this.toolStripSeparatorRegionSelect.Name = "toolStripSeparatorRegionSelect";
            this.toolStripSeparatorRegionSelect.Size = new System.Drawing.Size(216, 6);
            // 
            // toolStripMenuItemApplyLabel
            // 
            this.toolStripMenuItemApplyLabel.Name = "toolStripMenuItemApplyLabel";
            this.toolStripMenuItemApplyLabel.Size = new System.Drawing.Size(219, 22);
            this.toolStripMenuItemApplyLabel.Text = "Apply Label";
            // 
            // toolStripSeparatorApplyLabel
            // 
            this.toolStripSeparatorApplyLabel.Name = "toolStripSeparatorApplyLabel";
            this.toolStripSeparatorApplyLabel.Size = new System.Drawing.Size(216, 6);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Image = global::AutoScreenCapture.Properties.Resources.exit;
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.ShowShortcutKeys = false;
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(219, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // tabControlModules
            // 
            this.tabControlModules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControlModules.Controls.Add(this.tabPageSetup);
            this.tabControlModules.Controls.Add(this.tabPageScreenshots);
            this.tabControlModules.Controls.Add(this.tabPageScreens);
            this.tabControlModules.Controls.Add(this.tabPageRegions);
            this.tabControlModules.Controls.Add(this.tabPageEditors);
            this.tabControlModules.Controls.Add(this.tabPageSchedules);
            this.tabControlModules.Controls.Add(this.tabPageMacroTags);
            this.tabControlModules.Controls.Add(this.tabPageTriggers);
            this.tabControlModules.Location = new System.Drawing.Point(0, 220);
            this.tabControlModules.Multiline = true;
            this.tabControlModules.Name = "tabControlModules";
            this.tabControlModules.SelectedIndex = 0;
            this.tabControlModules.Size = new System.Drawing.Size(249, 407);
            this.tabControlModules.TabIndex = 0;
            this.tabControlModules.TabStop = false;
            // 
            // tabPageSetup
            // 
            this.tabPageSetup.AutoScroll = true;
            this.tabPageSetup.Controls.Add(this.groupBoxApplicationFocus);
            this.tabPageSetup.Controls.Add(this.groupBoxActiveWindowTitle);
            this.tabPageSetup.Controls.Add(this.groupBoxSecurity);
            this.tabPageSetup.Controls.Add(this.checkBoxScreenshotLabel);
            this.tabPageSetup.Controls.Add(this.comboBoxScreenshotLabel);
            this.tabPageSetup.Controls.Add(this.groupBoxCaptureDelay);
            this.tabPageSetup.Location = new System.Drawing.Point(4, 40);
            this.tabPageSetup.Name = "tabPageSetup";
            this.tabPageSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetup.Size = new System.Drawing.Size(241, 363);
            this.tabPageSetup.TabIndex = 0;
            this.tabPageSetup.Text = "Setup";
            this.tabPageSetup.UseVisualStyleBackColor = true;
            // 
            // groupBoxApplicationFocus
            // 
            this.groupBoxApplicationFocus.Controls.Add(this.numericUpDownApplicationFocusDelayAfter);
            this.groupBoxApplicationFocus.Controls.Add(this.numericUpDownApplicationFocusDelayBefore);
            this.groupBoxApplicationFocus.Controls.Add(this.labelApplicationFocusDelayAfter);
            this.groupBoxApplicationFocus.Controls.Add(this.labelApplicationFocusDelayBefore);
            this.groupBoxApplicationFocus.Controls.Add(this.buttonApplicationFocusTest);
            this.groupBoxApplicationFocus.Controls.Add(this.buttonApplicationFocusRefresh);
            this.groupBoxApplicationFocus.Controls.Add(this.comboBoxProcessList);
            this.groupBoxApplicationFocus.Location = new System.Drawing.Point(6, 323);
            this.groupBoxApplicationFocus.Name = "groupBoxApplicationFocus";
            this.groupBoxApplicationFocus.Size = new System.Drawing.Size(205, 128);
            this.groupBoxApplicationFocus.TabIndex = 0;
            this.groupBoxApplicationFocus.TabStop = false;
            this.groupBoxApplicationFocus.Text = "Application Focus";
            // 
            // numericUpDownApplicationFocusDelayAfter
            // 
            this.numericUpDownApplicationFocusDelayAfter.Location = new System.Drawing.Point(147, 71);
            this.numericUpDownApplicationFocusDelayAfter.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDownApplicationFocusDelayAfter.Name = "numericUpDownApplicationFocusDelayAfter";
            this.numericUpDownApplicationFocusDelayAfter.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownApplicationFocusDelayAfter.TabIndex = 0;
            this.numericUpDownApplicationFocusDelayAfter.TabStop = false;
            // 
            // numericUpDownApplicationFocusDelayBefore
            // 
            this.numericUpDownApplicationFocusDelayBefore.Location = new System.Drawing.Point(148, 47);
            this.numericUpDownApplicationFocusDelayBefore.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericUpDownApplicationFocusDelayBefore.Name = "numericUpDownApplicationFocusDelayBefore";
            this.numericUpDownApplicationFocusDelayBefore.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownApplicationFocusDelayBefore.TabIndex = 0;
            this.numericUpDownApplicationFocusDelayBefore.TabStop = false;
            // 
            // labelApplicationFocusDelayAfter
            // 
            this.labelApplicationFocusDelayAfter.AutoSize = true;
            this.labelApplicationFocusDelayAfter.Location = new System.Drawing.Point(6, 75);
            this.labelApplicationFocusDelayAfter.Name = "labelApplicationFocusDelayAfter";
            this.labelApplicationFocusDelayAfter.Size = new System.Drawing.Size(127, 13);
            this.labelApplicationFocusDelayAfter.TabIndex = 0;
            this.labelApplicationFocusDelayAfter.Text = "Delay After (milliseconds):";
            // 
            // labelApplicationFocusDelayBefore
            // 
            this.labelApplicationFocusDelayBefore.AutoSize = true;
            this.labelApplicationFocusDelayBefore.Location = new System.Drawing.Point(6, 49);
            this.labelApplicationFocusDelayBefore.Name = "labelApplicationFocusDelayBefore";
            this.labelApplicationFocusDelayBefore.Size = new System.Drawing.Size(136, 13);
            this.labelApplicationFocusDelayBefore.TabIndex = 0;
            this.labelApplicationFocusDelayBefore.Text = "Delay Before (milliseconds):";
            // 
            // buttonApplicationFocusTest
            // 
            this.buttonApplicationFocusTest.Location = new System.Drawing.Point(6, 98);
            this.buttonApplicationFocusTest.Name = "buttonApplicationFocusTest";
            this.buttonApplicationFocusTest.Size = new System.Drawing.Size(92, 23);
            this.buttonApplicationFocusTest.TabIndex = 0;
            this.buttonApplicationFocusTest.TabStop = false;
            this.buttonApplicationFocusTest.Text = "Test";
            this.buttonApplicationFocusTest.UseVisualStyleBackColor = true;
            this.buttonApplicationFocusTest.Click += new System.EventHandler(this.buttonApplicationFocusTest_Click);
            // 
            // buttonApplicationFocusRefresh
            // 
            this.buttonApplicationFocusRefresh.Location = new System.Drawing.Point(107, 98);
            this.buttonApplicationFocusRefresh.Name = "buttonApplicationFocusRefresh";
            this.buttonApplicationFocusRefresh.Size = new System.Drawing.Size(92, 23);
            this.buttonApplicationFocusRefresh.TabIndex = 0;
            this.buttonApplicationFocusRefresh.TabStop = false;
            this.buttonApplicationFocusRefresh.Text = "Refresh";
            this.buttonApplicationFocusRefresh.UseVisualStyleBackColor = true;
            this.buttonApplicationFocusRefresh.Click += new System.EventHandler(this.buttonApplicationFocusRefresh_Click);
            // 
            // comboBoxProcessList
            // 
            this.comboBoxProcessList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProcessList.FormattingEnabled = true;
            this.comboBoxProcessList.Location = new System.Drawing.Point(5, 19);
            this.comboBoxProcessList.Name = "comboBoxProcessList";
            this.comboBoxProcessList.Size = new System.Drawing.Size(193, 21);
            this.comboBoxProcessList.TabIndex = 0;
            this.comboBoxProcessList.TabStop = false;
            // 
            // groupBoxActiveWindowTitle
            // 
            this.groupBoxActiveWindowTitle.Controls.Add(this.checkBoxActiveWindowTitleComparisonCheckReverse);
            this.groupBoxActiveWindowTitle.Controls.Add(this.buttonDynamicRegexValidator);
            this.groupBoxActiveWindowTitle.Controls.Add(this.radioButtonRegularExpressionMatch);
            this.groupBoxActiveWindowTitle.Controls.Add(this.radioButtonCaseSensitiveMatch);
            this.groupBoxActiveWindowTitle.Controls.Add(this.radioButtonCaseInsensitiveMatch);
            this.groupBoxActiveWindowTitle.Controls.Add(this.textBoxActiveWindowTitle);
            this.groupBoxActiveWindowTitle.Controls.Add(this.checkBoxActiveWindowTitleComparisonCheck);
            this.groupBoxActiveWindowTitle.Location = new System.Drawing.Point(6, 178);
            this.groupBoxActiveWindowTitle.Name = "groupBoxActiveWindowTitle";
            this.groupBoxActiveWindowTitle.Size = new System.Drawing.Size(205, 139);
            this.groupBoxActiveWindowTitle.TabIndex = 0;
            this.groupBoxActiveWindowTitle.TabStop = false;
            this.groupBoxActiveWindowTitle.Text = "Active Window Title";
            // 
            // checkBoxActiveWindowTitleComparisonCheckReverse
            // 
            this.checkBoxActiveWindowTitleComparisonCheckReverse.AutoSize = true;
            this.checkBoxActiveWindowTitleComparisonCheckReverse.Location = new System.Drawing.Point(68, 19);
            this.checkBoxActiveWindowTitleComparisonCheckReverse.Name = "checkBoxActiveWindowTitleComparisonCheckReverse";
            this.checkBoxActiveWindowTitleComparisonCheckReverse.Size = new System.Drawing.Size(73, 17);
            this.checkBoxActiveWindowTitleComparisonCheckReverse.TabIndex = 1;
            this.checkBoxActiveWindowTitleComparisonCheckReverse.TabStop = false;
            this.checkBoxActiveWindowTitleComparisonCheckReverse.Text = "No Match";
            this.checkBoxActiveWindowTitleComparisonCheckReverse.UseVisualStyleBackColor = true;
            this.checkBoxActiveWindowTitleComparisonCheckReverse.CheckedChanged += new System.EventHandler(this.checkBoxActiveWindowTitleComparisonCheckReverse_CheckedChanged);
            // 
            // buttonDynamicRegexValidator
            // 
            this.buttonDynamicRegexValidator.Image = global::AutoScreenCapture.Properties.Resources.lightbulb;
            this.buttonDynamicRegexValidator.Location = new System.Drawing.Point(176, 111);
            this.buttonDynamicRegexValidator.Name = "buttonDynamicRegexValidator";
            this.buttonDynamicRegexValidator.Size = new System.Drawing.Size(23, 23);
            this.buttonDynamicRegexValidator.TabIndex = 0;
            this.buttonDynamicRegexValidator.TabStop = false;
            this.buttonDynamicRegexValidator.UseVisualStyleBackColor = true;
            this.buttonDynamicRegexValidator.Click += new System.EventHandler(this.toolStripMenuItemDynamicRegexValidator_Click);
            // 
            // radioButtonRegularExpressionMatch
            // 
            this.radioButtonRegularExpressionMatch.AutoSize = true;
            this.radioButtonRegularExpressionMatch.Location = new System.Drawing.Point(6, 114);
            this.radioButtonRegularExpressionMatch.Name = "radioButtonRegularExpressionMatch";
            this.radioButtonRegularExpressionMatch.Size = new System.Drawing.Size(149, 17);
            this.radioButtonRegularExpressionMatch.TabIndex = 0;
            this.radioButtonRegularExpressionMatch.Text = "Regular Expression Match";
            this.radioButtonRegularExpressionMatch.UseVisualStyleBackColor = true;
            // 
            // radioButtonCaseSensitiveMatch
            // 
            this.radioButtonCaseSensitiveMatch.AutoSize = true;
            this.radioButtonCaseSensitiveMatch.Location = new System.Drawing.Point(6, 68);
            this.radioButtonCaseSensitiveMatch.Name = "radioButtonCaseSensitiveMatch";
            this.radioButtonCaseSensitiveMatch.Size = new System.Drawing.Size(128, 17);
            this.radioButtonCaseSensitiveMatch.TabIndex = 0;
            this.radioButtonCaseSensitiveMatch.Text = "Case Sensitive Match";
            this.radioButtonCaseSensitiveMatch.UseVisualStyleBackColor = true;
            // 
            // radioButtonCaseInsensitiveMatch
            // 
            this.radioButtonCaseInsensitiveMatch.AutoSize = true;
            this.radioButtonCaseInsensitiveMatch.Location = new System.Drawing.Point(6, 91);
            this.radioButtonCaseInsensitiveMatch.Name = "radioButtonCaseInsensitiveMatch";
            this.radioButtonCaseInsensitiveMatch.Size = new System.Drawing.Size(135, 17);
            this.radioButtonCaseInsensitiveMatch.TabIndex = 0;
            this.radioButtonCaseInsensitiveMatch.Text = "Case Insensitive Match";
            this.radioButtonCaseInsensitiveMatch.UseVisualStyleBackColor = true;
            // 
            // textBoxActiveWindowTitle
            // 
            this.textBoxActiveWindowTitle.Enabled = false;
            this.textBoxActiveWindowTitle.Location = new System.Drawing.Point(6, 42);
            this.textBoxActiveWindowTitle.MaxLength = 500;
            this.textBoxActiveWindowTitle.Name = "textBoxActiveWindowTitle";
            this.textBoxActiveWindowTitle.Size = new System.Drawing.Size(193, 20);
            this.textBoxActiveWindowTitle.TabIndex = 0;
            this.textBoxActiveWindowTitle.TabStop = false;
            // 
            // checkBoxActiveWindowTitleComparisonCheck
            // 
            this.checkBoxActiveWindowTitleComparisonCheck.AutoSize = true;
            this.checkBoxActiveWindowTitleComparisonCheck.Location = new System.Drawing.Point(6, 19);
            this.checkBoxActiveWindowTitleComparisonCheck.Name = "checkBoxActiveWindowTitleComparisonCheck";
            this.checkBoxActiveWindowTitleComparisonCheck.Size = new System.Drawing.Size(56, 17);
            this.checkBoxActiveWindowTitleComparisonCheck.TabIndex = 0;
            this.checkBoxActiveWindowTitleComparisonCheck.TabStop = false;
            this.checkBoxActiveWindowTitleComparisonCheck.Text = "Match";
            this.checkBoxActiveWindowTitleComparisonCheck.UseVisualStyleBackColor = true;
            this.checkBoxActiveWindowTitleComparisonCheck.CheckedChanged += new System.EventHandler(this.checkBoxActiveWindowTitleComparisonCheck_CheckedChanged);
            // 
            // groupBoxSecurity
            // 
            this.groupBoxSecurity.Controls.Add(this.labelPasswordDescription);
            this.groupBoxSecurity.Controls.Add(this.buttonSetPassphrase);
            this.groupBoxSecurity.Controls.Add(this.textBoxPassphrase);
            this.groupBoxSecurity.Location = new System.Drawing.Point(6, 457);
            this.groupBoxSecurity.Name = "groupBoxSecurity";
            this.groupBoxSecurity.Size = new System.Drawing.Size(205, 110);
            this.groupBoxSecurity.TabIndex = 0;
            this.groupBoxSecurity.TabStop = false;
            this.groupBoxSecurity.Text = "Security";
            // 
            // labelPasswordDescription
            // 
            this.labelPasswordDescription.Location = new System.Drawing.Point(7, 21);
            this.labelPasswordDescription.Name = "labelPasswordDescription";
            this.labelPasswordDescription.Size = new System.Drawing.Size(186, 55);
            this.labelPasswordDescription.TabIndex = 0;
            this.labelPasswordDescription.Text = "This passphrase will be required whenever screen capturing is stopped, this inter" +
    "face is shown, or the application is exiting:";
            // 
            // buttonSetPassphrase
            // 
            this.buttonSetPassphrase.Enabled = false;
            this.buttonSetPassphrase.Image = ((System.Drawing.Image)(resources.GetObject("buttonSetPassphrase.Image")));
            this.buttonSetPassphrase.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSetPassphrase.Location = new System.Drawing.Point(131, 80);
            this.buttonSetPassphrase.Name = "buttonSetPassphrase";
            this.buttonSetPassphrase.Size = new System.Drawing.Size(68, 23);
            this.buttonSetPassphrase.TabIndex = 0;
            this.buttonSetPassphrase.TabStop = false;
            this.buttonSetPassphrase.Text = "Lock";
            this.buttonSetPassphrase.UseVisualStyleBackColor = true;
            this.buttonSetPassphrase.Click += new System.EventHandler(this.buttonSetPassphrase_Click);
            // 
            // textBoxPassphrase
            // 
            this.textBoxPassphrase.Location = new System.Drawing.Point(6, 82);
            this.textBoxPassphrase.MaxLength = 30;
            this.textBoxPassphrase.Name = "textBoxPassphrase";
            this.textBoxPassphrase.Size = new System.Drawing.Size(119, 20);
            this.textBoxPassphrase.TabIndex = 0;
            this.textBoxPassphrase.TabStop = false;
            this.textBoxPassphrase.TextChanged += new System.EventHandler(this.TextChanged_textBoxPassphrase);
            // 
            // checkBoxScreenshotLabel
            // 
            this.checkBoxScreenshotLabel.AutoSize = true;
            this.checkBoxScreenshotLabel.Location = new System.Drawing.Point(6, 133);
            this.checkBoxScreenshotLabel.Name = "checkBoxScreenshotLabel";
            this.checkBoxScreenshotLabel.Size = new System.Drawing.Size(193, 17);
            this.checkBoxScreenshotLabel.TabIndex = 0;
            this.checkBoxScreenshotLabel.TabStop = false;
            this.checkBoxScreenshotLabel.Text = "Apply this label to each screenshot:";
            this.checkBoxScreenshotLabel.UseVisualStyleBackColor = true;
            // 
            // comboBoxScreenshotLabel
            // 
            this.comboBoxScreenshotLabel.FormattingEnabled = true;
            this.comboBoxScreenshotLabel.Location = new System.Drawing.Point(6, 151);
            this.comboBoxScreenshotLabel.MaxDropDownItems = 10;
            this.comboBoxScreenshotLabel.MaxLength = 500;
            this.comboBoxScreenshotLabel.Name = "comboBoxScreenshotLabel";
            this.comboBoxScreenshotLabel.Size = new System.Drawing.Size(205, 21);
            this.comboBoxScreenshotLabel.TabIndex = 0;
            this.comboBoxScreenshotLabel.TabStop = false;
            this.comboBoxScreenshotLabel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxScreenshotLabel_SelectedIndexChanged);
            // 
            // groupBoxCaptureDelay
            // 
            this.groupBoxCaptureDelay.Controls.Add(this.labelLimit);
            this.groupBoxCaptureDelay.Controls.Add(this.checkBoxInitialScreenshot);
            this.groupBoxCaptureDelay.Controls.Add(this.numericUpDownCaptureLimit);
            this.groupBoxCaptureDelay.Controls.Add(this.checkBoxCaptureLimit);
            this.groupBoxCaptureDelay.Controls.Add(this.labelMillisecondsInterval);
            this.groupBoxCaptureDelay.Controls.Add(this.numericUpDownMillisecondsInterval);
            this.groupBoxCaptureDelay.Controls.Add(this.labelSecondsInterval);
            this.groupBoxCaptureDelay.Controls.Add(this.labelMinutesInterval);
            this.groupBoxCaptureDelay.Controls.Add(this.labelHoursInterval);
            this.groupBoxCaptureDelay.Controls.Add(this.numericUpDownSecondsInterval);
            this.groupBoxCaptureDelay.Controls.Add(this.numericUpDownMinutesInterval);
            this.groupBoxCaptureDelay.Controls.Add(this.numericUpDownHoursInterval);
            this.groupBoxCaptureDelay.Location = new System.Drawing.Point(6, 5);
            this.groupBoxCaptureDelay.Name = "groupBoxCaptureDelay";
            this.groupBoxCaptureDelay.Size = new System.Drawing.Size(205, 122);
            this.groupBoxCaptureDelay.TabIndex = 0;
            this.groupBoxCaptureDelay.TabStop = false;
            this.groupBoxCaptureDelay.Text = "Interval";
            // 
            // labelLimit
            // 
            this.labelLimit.AutoSize = true;
            this.labelLimit.Location = new System.Drawing.Point(171, 47);
            this.labelLimit.Name = "labelLimit";
            this.labelLimit.Size = new System.Drawing.Size(24, 13);
            this.labelLimit.TabIndex = 0;
            this.labelLimit.Text = "limit";
            // 
            // checkBoxInitialScreenshot
            // 
            this.checkBoxInitialScreenshot.AutoSize = true;
            this.checkBoxInitialScreenshot.Location = new System.Drawing.Point(110, 20);
            this.checkBoxInitialScreenshot.Name = "checkBoxInitialScreenshot";
            this.checkBoxInitialScreenshot.Size = new System.Drawing.Size(90, 17);
            this.checkBoxInitialScreenshot.TabIndex = 0;
            this.checkBoxInitialScreenshot.TabStop = false;
            this.checkBoxInitialScreenshot.Text = "Initial Capture";
            this.checkBoxInitialScreenshot.UseVisualStyleBackColor = true;
            this.checkBoxInitialScreenshot.Click += new System.EventHandler(this.SaveSettings);
            this.checkBoxInitialScreenshot.Leave += new System.EventHandler(this.SaveSettings);
            // 
            // numericUpDownCaptureLimit
            // 
            this.numericUpDownCaptureLimit.Location = new System.Drawing.Point(127, 45);
            this.numericUpDownCaptureLimit.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownCaptureLimit.Name = "numericUpDownCaptureLimit";
            this.numericUpDownCaptureLimit.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownCaptureLimit.TabIndex = 0;
            this.numericUpDownCaptureLimit.TabStop = false;
            this.numericUpDownCaptureLimit.Leave += new System.EventHandler(this.SaveSettings);
            // 
            // checkBoxCaptureLimit
            // 
            this.checkBoxCaptureLimit.AutoSize = true;
            this.checkBoxCaptureLimit.Location = new System.Drawing.Point(110, 47);
            this.checkBoxCaptureLimit.Name = "checkBoxCaptureLimit";
            this.checkBoxCaptureLimit.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCaptureLimit.TabIndex = 0;
            this.checkBoxCaptureLimit.TabStop = false;
            this.checkBoxCaptureLimit.UseVisualStyleBackColor = true;
            this.checkBoxCaptureLimit.CheckedChanged += new System.EventHandler(this.CheckedChanged_checkBoxCaptureLimit);
            this.checkBoxCaptureLimit.Click += new System.EventHandler(this.SaveSettings);
            this.checkBoxCaptureLimit.Leave += new System.EventHandler(this.SaveSettings);
            // 
            // labelMillisecondsInterval
            // 
            this.labelMillisecondsInterval.AutoSize = true;
            this.labelMillisecondsInterval.Location = new System.Drawing.Point(54, 99);
            this.labelMillisecondsInterval.Name = "labelMillisecondsInterval";
            this.labelMillisecondsInterval.Size = new System.Drawing.Size(63, 13);
            this.labelMillisecondsInterval.TabIndex = 0;
            this.labelMillisecondsInterval.Text = "milliseconds";
            // 
            // numericUpDownMillisecondsInterval
            // 
            this.numericUpDownMillisecondsInterval.Location = new System.Drawing.Point(6, 97);
            this.numericUpDownMillisecondsInterval.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownMillisecondsInterval.Name = "numericUpDownMillisecondsInterval";
            this.numericUpDownMillisecondsInterval.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownMillisecondsInterval.TabIndex = 0;
            this.numericUpDownMillisecondsInterval.TabStop = false;
            this.numericUpDownMillisecondsInterval.Leave += new System.EventHandler(this.SaveSettings);
            // 
            // labelSecondsInterval
            // 
            this.labelSecondsInterval.AutoSize = true;
            this.labelSecondsInterval.Location = new System.Drawing.Point(54, 73);
            this.labelSecondsInterval.Name = "labelSecondsInterval";
            this.labelSecondsInterval.Size = new System.Drawing.Size(47, 13);
            this.labelSecondsInterval.TabIndex = 0;
            this.labelSecondsInterval.Text = "seconds";
            // 
            // labelMinutesInterval
            // 
            this.labelMinutesInterval.AutoSize = true;
            this.labelMinutesInterval.Location = new System.Drawing.Point(54, 47);
            this.labelMinutesInterval.Name = "labelMinutesInterval";
            this.labelMinutesInterval.Size = new System.Drawing.Size(43, 13);
            this.labelMinutesInterval.TabIndex = 0;
            this.labelMinutesInterval.Text = "minutes";
            // 
            // labelHoursInterval
            // 
            this.labelHoursInterval.AutoSize = true;
            this.labelHoursInterval.Location = new System.Drawing.Point(54, 21);
            this.labelHoursInterval.Name = "labelHoursInterval";
            this.labelHoursInterval.Size = new System.Drawing.Size(33, 13);
            this.labelHoursInterval.TabIndex = 0;
            this.labelHoursInterval.Text = "hours";
            // 
            // numericUpDownSecondsInterval
            // 
            this.numericUpDownSecondsInterval.Location = new System.Drawing.Point(6, 71);
            this.numericUpDownSecondsInterval.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownSecondsInterval.Name = "numericUpDownSecondsInterval";
            this.numericUpDownSecondsInterval.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownSecondsInterval.TabIndex = 0;
            this.numericUpDownSecondsInterval.TabStop = false;
            this.numericUpDownSecondsInterval.Leave += new System.EventHandler(this.SaveSettings);
            // 
            // numericUpDownMinutesInterval
            // 
            this.numericUpDownMinutesInterval.Location = new System.Drawing.Point(6, 45);
            this.numericUpDownMinutesInterval.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinutesInterval.Name = "numericUpDownMinutesInterval";
            this.numericUpDownMinutesInterval.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownMinutesInterval.TabIndex = 0;
            this.numericUpDownMinutesInterval.TabStop = false;
            this.numericUpDownMinutesInterval.Leave += new System.EventHandler(this.SaveSettings);
            // 
            // numericUpDownHoursInterval
            // 
            this.numericUpDownHoursInterval.Location = new System.Drawing.Point(6, 19);
            this.numericUpDownHoursInterval.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHoursInterval.Name = "numericUpDownHoursInterval";
            this.numericUpDownHoursInterval.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownHoursInterval.TabIndex = 0;
            this.numericUpDownHoursInterval.TabStop = false;
            this.numericUpDownHoursInterval.Leave += new System.EventHandler(this.SaveSettings);
            // 
            // tabPageScreenshots
            // 
            this.tabPageScreenshots.AutoScroll = true;
            this.tabPageScreenshots.Controls.Add(this.listBoxScreenshots);
            this.tabPageScreenshots.Location = new System.Drawing.Point(4, 40);
            this.tabPageScreenshots.Name = "tabPageScreenshots";
            this.tabPageScreenshots.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScreenshots.Size = new System.Drawing.Size(241, 363);
            this.tabPageScreenshots.TabIndex = 1;
            this.tabPageScreenshots.Text = "Screenshots";
            this.tabPageScreenshots.UseVisualStyleBackColor = true;
            // 
            // tabPageScreens
            // 
            this.tabPageScreens.AutoScroll = true;
            this.tabPageScreens.Location = new System.Drawing.Point(4, 40);
            this.tabPageScreens.Name = "tabPageScreens";
            this.tabPageScreens.Size = new System.Drawing.Size(241, 363);
            this.tabPageScreens.TabIndex = 5;
            this.tabPageScreens.Text = "Screens";
            this.tabPageScreens.UseVisualStyleBackColor = true;
            // 
            // tabPageRegions
            // 
            this.tabPageRegions.AutoScroll = true;
            this.tabPageRegions.Location = new System.Drawing.Point(4, 40);
            this.tabPageRegions.Name = "tabPageRegions";
            this.tabPageRegions.Size = new System.Drawing.Size(241, 363);
            this.tabPageRegions.TabIndex = 4;
            this.tabPageRegions.Text = "Regions";
            this.tabPageRegions.UseVisualStyleBackColor = true;
            // 
            // tabPageEditors
            // 
            this.tabPageEditors.AutoScroll = true;
            this.tabPageEditors.Location = new System.Drawing.Point(4, 40);
            this.tabPageEditors.Name = "tabPageEditors";
            this.tabPageEditors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditors.Size = new System.Drawing.Size(241, 363);
            this.tabPageEditors.TabIndex = 2;
            this.tabPageEditors.Text = "Editors";
            this.tabPageEditors.UseVisualStyleBackColor = true;
            // 
            // tabPageSchedules
            // 
            this.tabPageSchedules.Location = new System.Drawing.Point(4, 40);
            this.tabPageSchedules.Name = "tabPageSchedules";
            this.tabPageSchedules.Size = new System.Drawing.Size(241, 363);
            this.tabPageSchedules.TabIndex = 8;
            this.tabPageSchedules.Text = "Schedules";
            this.tabPageSchedules.UseVisualStyleBackColor = true;
            // 
            // tabPageMacroTags
            // 
            this.tabPageMacroTags.AutoScroll = true;
            this.tabPageMacroTags.Location = new System.Drawing.Point(4, 40);
            this.tabPageMacroTags.Name = "tabPageMacroTags";
            this.tabPageMacroTags.Size = new System.Drawing.Size(241, 363);
            this.tabPageMacroTags.TabIndex = 7;
            this.tabPageMacroTags.Text = "Macro Tags";
            this.tabPageMacroTags.UseVisualStyleBackColor = true;
            // 
            // tabPageTriggers
            // 
            this.tabPageTriggers.AutoScroll = true;
            this.tabPageTriggers.Location = new System.Drawing.Point(4, 40);
            this.tabPageTriggers.Name = "tabPageTriggers";
            this.tabPageTriggers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTriggers.Size = new System.Drawing.Size(241, 363);
            this.tabPageTriggers.TabIndex = 3;
            this.tabPageTriggers.Text = "Triggers";
            this.tabPageTriggers.UseVisualStyleBackColor = true;
            // 
            // timerScheduledCapture
            // 
            this.timerScheduledCapture.Interval = 1000;
            this.timerScheduledCapture.Tick += new System.EventHandler(this.timerScheduledCapture_Tick);
            // 
            // timerScreenCapture
            // 
            this.timerScreenCapture.Tick += new System.EventHandler(this.timerScreenCapture_Tick);
            // 
            // comboBoxFilterValue
            // 
            this.comboBoxFilterValue.DropDownHeight = 300;
            this.comboBoxFilterValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterValue.DropDownWidth = 700;
            this.comboBoxFilterValue.Enabled = false;
            this.comboBoxFilterValue.FormattingEnabled = true;
            this.comboBoxFilterValue.IntegralHeight = false;
            this.comboBoxFilterValue.Location = new System.Drawing.Point(133, 30);
            this.comboBoxFilterValue.Name = "comboBoxFilterValue";
            this.comboBoxFilterValue.Size = new System.Drawing.Size(88, 21);
            this.comboBoxFilterValue.TabIndex = 0;
            this.comboBoxFilterValue.TabStop = false;
            this.comboBoxFilterValue.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterValue_SelectedIndexChanged);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(1, 33);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(32, 13);
            this.labelFilter.TabIndex = 0;
            this.labelFilter.Text = "Filter:";
            // 
            // buttonRefreshFilterValues
            // 
            this.buttonRefreshFilterValues.BackColor = System.Drawing.Color.Transparent;
            this.buttonRefreshFilterValues.Enabled = false;
            this.buttonRefreshFilterValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshFilterValues.ForeColor = System.Drawing.Color.Transparent;
            this.buttonRefreshFilterValues.Image = global::AutoScreenCapture.Properties.Resources.refresh;
            this.buttonRefreshFilterValues.Location = new System.Drawing.Point(227, 30);
            this.buttonRefreshFilterValues.Name = "buttonRefreshFilterValues";
            this.buttonRefreshFilterValues.Size = new System.Drawing.Size(21, 21);
            this.buttonRefreshFilterValues.TabIndex = 0;
            this.buttonRefreshFilterValues.TabStop = false;
            this.buttonRefreshFilterValues.UseVisualStyleBackColor = false;
            this.buttonRefreshFilterValues.Click += new System.EventHandler(this.buttonRefreshFilterValues_Click);
            // 
            // comboBoxFilterType
            // 
            this.comboBoxFilterType.DropDownHeight = 100;
            this.comboBoxFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterType.DropDownWidth = 100;
            this.comboBoxFilterType.FormattingEnabled = true;
            this.comboBoxFilterType.IntegralHeight = false;
            this.comboBoxFilterType.Items.AddRange(new object[] {
            "",
            "Image Format",
            "Label",
            "Process Name",
            "Window Title"});
            this.comboBoxFilterType.Location = new System.Drawing.Point(39, 30);
            this.comboBoxFilterType.Name = "comboBoxFilterType";
            this.comboBoxFilterType.Size = new System.Drawing.Size(88, 21);
            this.comboBoxFilterType.TabIndex = 0;
            this.comboBoxFilterType.TabStop = false;
            this.comboBoxFilterType.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterType_SelectedIndexChanged);
            // 
            // timerPerformMaintenance
            // 
            this.timerPerformMaintenance.Enabled = true;
            this.timerPerformMaintenance.Interval = 300000;
            this.timerPerformMaintenance.Tick += new System.EventHandler(this.timerPerformMaintenance_Tick);
            // 
            // labelHelp
            // 
            this.labelHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHelp.AutoEllipsis = true;
            this.labelHelp.BackColor = System.Drawing.Color.LightYellow;
            this.labelHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHelp.Image = global::AutoScreenCapture.Properties.Resources.about;
            this.labelHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelHelp.Location = new System.Drawing.Point(2, 4);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(1036, 17);
            this.labelHelp.TabIndex = 0;
            this.labelHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelHelp.Click += new System.EventHandler(this.labelHelp_Click);
            // 
            // timerShowNextHelpTip
            // 
            this.timerShowNextHelpTip.Enabled = true;
            this.timerShowNextHelpTip.Interval = 20000;
            this.timerShowNextHelpTip.Tick += new System.EventHandler(this.timerShowNextHelpTip_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 655);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.comboBoxFilterType);
            this.Controls.Add(this.buttonRefreshFilterValues);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.comboBoxFilterValue);
            this.Controls.Add(this.tabControlModules);
            this.Controls.Add(this.tabControlViews);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.monthCalendar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1056, 694);
            this.Name = "FormMain";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormViewer_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuStripSystemTrayIcon.ResumeLayout(false);
            this.tabControlModules.ResumeLayout(false);
            this.tabPageSetup.ResumeLayout(false);
            this.tabPageSetup.PerformLayout();
            this.groupBoxApplicationFocus.ResumeLayout(false);
            this.groupBoxApplicationFocus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownApplicationFocusDelayAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownApplicationFocusDelayBefore)).EndInit();
            this.groupBoxActiveWindowTitle.ResumeLayout(false);
            this.groupBoxActiveWindowTitle.PerformLayout();
            this.groupBoxSecurity.ResumeLayout(false);
            this.groupBoxSecurity.PerformLayout();
            this.groupBoxCaptureDelay.ResumeLayout(false);
            this.groupBoxCaptureDelay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCaptureLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMillisecondsInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondsInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutesInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoursInterval)).EndInit();
            this.tabPageScreenshots.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl tabControlViews;
        private System.Windows.Forms.ListBox listBoxScreenshots;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSystemTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStartScreenCapture;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStopScreenCapture;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripScreenshot;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowHideInterface;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorInterface;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorCaptureNow;
        private System.Windows.Forms.TabControl tabControlModules;
        private System.Windows.Forms.TabPage tabPageSetup;
        private System.Windows.Forms.TabPage tabPageScreenshots;
        private System.Windows.Forms.GroupBox groupBoxCaptureDelay;
        private System.Windows.Forms.Label labelMillisecondsInterval;
        private System.Windows.Forms.NumericUpDown numericUpDownMillisecondsInterval;
        private System.Windows.Forms.Label labelSecondsInterval;
        private System.Windows.Forms.Label labelMinutesInterval;
        private System.Windows.Forms.Label labelHoursInterval;
        private System.Windows.Forms.NumericUpDown numericUpDownSecondsInterval;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutesInterval;
        private System.Windows.Forms.NumericUpDown numericUpDownHoursInterval;
        private System.Windows.Forms.CheckBox checkBoxCaptureLimit;
        private System.Windows.Forms.CheckBox checkBoxInitialScreenshot;
        private System.Windows.Forms.NumericUpDown numericUpDownCaptureLimit;
        private System.Windows.Forms.Label labelLimit;
        private System.Windows.Forms.Timer timerScheduledCapture;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorAbout;
        private System.Windows.Forms.Timer timerScreenCapture;
        private System.Windows.Forms.TabPage tabPageEditors;
        private System.Windows.Forms.TabPage tabPageTriggers;
        private System.Windows.Forms.TabPage tabPageRegions;
        private System.Windows.Forms.TabPage tabPageScreens;
        private System.Windows.Forms.TabPage tabPageMacroTags;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonStartScreenCapture;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonStopScreenCapture;
        private ComboBox comboBoxFilterValue;
        private Label labelFilter;
        private Button buttonRefreshFilterValues;
        private ComboBox comboBoxFilterType;
        private Timer timerPerformMaintenance;
        private ComboBox comboBoxScreenshotLabel;
        private CheckBox checkBoxScreenshotLabel;
        private ToolStripMenuItem toolStripMenuItemApplyLabel;
        private ToolStripSeparator toolStripSeparatorApplyLabel;
        private GroupBox groupBoxSecurity;
        private Label labelPasswordDescription;
        private Button buttonSetPassphrase;
        private TextBox textBoxPassphrase;
        private ToolStripStatusLabel toolStripInfo;
        private TabPage tabPageSchedules;
        private ToolStripMenuItem toolStripMenuItemCaptureNowEdit;
        private ToolStripMenuItem toolStripMenuItemCaptureNowArchive;
        private Label labelHelp;
        private ToolStripSplitButton toolStripSplitButtonKeyboardShortcuts;
        private Timer timerShowNextHelpTip;
        private ToolStripSplitButton toolStripSplitButtonHelp;
        private GroupBox groupBoxActiveWindowTitle;
        private TextBox textBoxActiveWindowTitle;
        private CheckBox checkBoxActiveWindowTitleComparisonCheck;
        private ToolStripMenuItem toolStripMenuItemRegionSelectClipboard;
        private ToolStripMenuItem toolStripMenuItemRegionSelectClipboardAutoSave;
        private ToolStripMenuItem toolStripMenuItemRegionSelectClipboardAutoSaveEdit;
        private ToolStripSeparator toolStripSeparatorRegionSelect;
        private ToolStripSeparator toolStripSeparatorTools;
        private GroupBox groupBoxApplicationFocus;
        private ComboBox comboBoxProcessList;
        private Button buttonApplicationFocusTest;
        private Button buttonApplicationFocusRefresh;
        private ToolStripSeparator toolStripSeparatorScreenCapture;
        private Label labelApplicationFocusDelayAfter;
        private Label labelApplicationFocusDelayBefore;
        private NumericUpDown numericUpDownApplicationFocusDelayAfter;
        private NumericUpDown numericUpDownApplicationFocusDelayBefore;
        private ToolStripMenuItem toolStripMenuItemEmailSettings;
        private ToolStripMenuItem toolStripMenuItemFileTransferSettings;
        private ToolStripMenuItem toolStripMenuItemAdd;
        private ToolStripMenuItem toolStripMenuItemAddScreen;
        private ToolStripMenuItem toolStripMenuItemAddRegion;
        private ToolStripMenuItem toolStripMenuItemAddEditor;
        private ToolStripMenuItem toolStripMenuItemAddSchedule;
        private ToolStripMenuItem toolStripMenuItemAddMacroTag;
        private ToolStripMenuItem toolStripMenuItemAddTrigger;
        private ToolStripMenuItem toolStripMenuItemRegionSelect;
        private ToolStripMenuItem toolStripMenuItemSettings;
        private RadioButton radioButtonRegularExpressionMatch;
        private RadioButton radioButtonCaseSensitiveMatch;
        private RadioButton radioButtonCaseInsensitiveMatch;
        private ToolStripMenuItem toolStripMenuItemTools;
        private ToolStripMenuItem toolStripMenuItemDynamicRegexValidator;
        private ToolStripMenuItem toolStripMenuItemScreenCaptureStatus;
        private Button buttonDynamicRegexValidator;
        private ToolStripMenuItem toolStripMenuItemChange;
        private ToolStripMenuItem toolStripMenuItemChangeScreen;
        private ToolStripMenuItem toolStripMenuItemChangeRegion;
        private ToolStripMenuItem toolStripMenuItemChangeEditor;
        private ToolStripMenuItem toolStripMenuItemChangeSchedule;
        private ToolStripMenuItem toolStripMenuItemChangeMacroTag;
        private ToolStripMenuItem toolStripMenuItemChangeTrigger;
        private ToolStripMenuItem toolStripMenuItemRegionSelectOptions;
        private ToolStripSeparator toolStripSeparatorRegionSelectOptions;
        private ToolStripMenuItem toolStripMenuItemFloatingScreenshot;
        private CheckBox checkBoxActiveWindowTitleComparisonCheckReverse;
    }
}