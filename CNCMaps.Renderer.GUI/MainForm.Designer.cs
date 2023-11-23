using System.Windows.Forms;

namespace CNCMaps.GUI {
	partial class MainForm {
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbMiscOptions = new System.Windows.Forms.GroupBox();
            this.lblMiscHeader = new System.Windows.Forms.Label();
            this.gbMarkings = new System.Windows.Forms.GroupBox();
            this.cbDiagnosticWindow = new System.Windows.Forms.CheckBox();
            this.cbTunnelPosition = new System.Windows.Forms.CheckBox();
            this.cbMarkIceGrowth = new System.Windows.Forms.CheckBox();
            this.cbEmphasizeOre = new System.Windows.Forms.CheckBox();
            this.cbTunnelPaths = new System.Windows.Forms.CheckBox();
            this.gbStartMarkers = new System.Windows.Forms.GroupBox();
            this.cbStartMarkers = new System.Windows.Forms.CheckBox();
            this.lblMarkerSize = new System.Windows.Forms.Label();
            this.lblStartMarkerType = new System.Windows.Forms.Label();
            this.cbMarkerSize = new System.Windows.Forms.ComboBox();
            this.cmbStartMarkers = new System.Windows.Forms.ComboBox();
            this.lblSquaredStartPosDescription = new System.Windows.Forms.Label();
            this.gbSizeMode = new System.Windows.Forms.GroupBox();
            this.rbSizeAuto = new System.Windows.Forms.RadioButton();
            this.rbSizeFullmap = new System.Windows.Forms.RadioButton();
            this.rbSizeLocal = new System.Windows.Forms.RadioButton();
            this.gbThumbs = new System.Windows.Forms.GroupBox();
            this.cbCompressTiles = new System.Windows.Forms.CheckBox();
            this.lblMarkersType = new System.Windows.Forms.Label();
            this.cbFixOverlay = new System.Windows.Forms.CheckBox();
            this.cbMarkersType = new System.Windows.Forms.ComboBox();
            this.cbBackup = new System.Windows.Forms.CheckBox();
            this.cbReplacePreview = new System.Windows.Forms.CheckBox();
            this.ckbFixupTiles = new System.Windows.Forms.CheckBox();
            this.gbInputOutput = new System.Windows.Forms.GroupBox();
            this.gbFileName = new System.Windows.Forms.GroupBox();
            this.rbUseFilename = new System.Windows.Forms.RadioButton();
            this.tbCustomOutput = new System.Windows.Forms.TextBox();
            this.rbAutoFilename = new System.Windows.Forms.RadioButton();
            this.rbCustomFilename = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEngineFS = new System.Windows.Forms.RadioButton();
            this.lbEngine = new System.Windows.Forms.Label();
            this.rbEngineTS = new System.Windows.Forms.RadioButton();
            this.rbEngineAuto = new System.Windows.Forms.RadioButton();
            this.rbEngineYR = new System.Windows.Forms.RadioButton();
            this.rbEngineRA2 = new System.Windows.Forms.RadioButton();
            this.gbModConfig = new System.Windows.Forms.GroupBox();
            this.btnModEditor = new System.Windows.Forms.Button();
            this.tbModConfig = new System.Windows.Forms.TextBox();
            this.ckbModConfig = new System.Windows.Forms.CheckBox();
            this.gbImageFormat = new System.Windows.Forms.GroupBox();
            this.lblThumbSize = new System.Windows.Forms.Label();
            this.cbThumbPNG = new System.Windows.Forms.CheckBox();
            this.cbPreserveThumbAspect = new System.Windows.Forms.CheckBox();
            this.tbThumbDimensions = new System.Windows.Forms.TextBox();
            this.cbOutputThumbnail = new System.Windows.Forms.CheckBox();
            this.lblQuality = new System.Windows.Forms.Label();
            this.lblCompressionLevel = new System.Windows.Forms.Label();
            this.nudEncodingQuality = new System.Windows.Forms.NumericUpDown();
            this.cbOutputJPG = new System.Windows.Forms.CheckBox();
            this.cbOutputPNG = new System.Windows.Forms.CheckBox();
            this.nudCompression = new System.Windows.Forms.NumericUpDown();
            this.tbMixDir = new System.Windows.Forms.TextBox();
            this.lblMixFiles = new System.Windows.Forms.Label();
            this.btnBrowseMixDir = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lblInputMap = new System.Windows.Forms.Label();
            this.btnBrowseInput = new System.Windows.Forms.Button();
            this.btnRenderExecute = new System.Windows.Forms.Button();
            this.tbCommandPreview = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFill = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblBatchMapList = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpMain = new System.Windows.Forms.TabPage();
            this.lblCommand = new System.Windows.Forms.Label();
            this.tpMisc = new System.Windows.Forms.TabPage();
            this.tpBatch = new System.Windows.Forms.TabPage();
            this.gbBatchRender = new System.Windows.Forms.GroupBox();
            this.btnBatchRender = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.lblBatchDesc = new System.Windows.Forms.Label();
            this.tbBatchInput = new System.Windows.Forms.TextBox();
            this.btnBrowseMaps = new System.Windows.Forms.Button();
            this.tpLog = new System.Windows.Forms.TabPage();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.btnCheckForUpdate = new System.Windows.Forms.Button();
            this.ckbCheckForUpdates = new System.Windows.Forms.CheckBox();
            this.lblCopyright = new System.Windows.Forms.LinkLabel();
            this.gbMiscOptions.SuspendLayout();
            this.gbMarkings.SuspendLayout();
            this.gbStartMarkers.SuspendLayout();
            this.gbSizeMode.SuspendLayout();
            this.gbThumbs.SuspendLayout();
            this.gbInputOutput.SuspendLayout();
            this.gbFileName.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbModConfig.SuspendLayout();
            this.gbImageFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEncodingQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCompression)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.tpMisc.SuspendLayout();
            this.tpBatch.SuspendLayout();
            this.gbBatchRender.SuspendLayout();
            this.tpLog.SuspendLayout();
            this.gbLog.SuspendLayout();
            this.tpAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMiscOptions
            // 
            this.gbMiscOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMiscOptions.Controls.Add(this.lblMiscHeader);
            this.gbMiscOptions.Controls.Add(this.gbMarkings);
            this.gbMiscOptions.Controls.Add(this.gbStartMarkers);
            this.gbMiscOptions.Controls.Add(this.gbSizeMode);
            this.gbMiscOptions.Controls.Add(this.gbThumbs);
            this.gbMiscOptions.Location = new System.Drawing.Point(6, 6);
            this.gbMiscOptions.Name = "gbMiscOptions";
            this.gbMiscOptions.Size = new System.Drawing.Size(592, 392);
            this.gbMiscOptions.TabIndex = 0;
            this.gbMiscOptions.TabStop = false;
            this.gbMiscOptions.Text = "杂项设置";
            this.gbMiscOptions.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputDragDrop);
            this.gbMiscOptions.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputDragEnter);
            // 
            // lblMiscHeader
            // 
            this.lblMiscHeader.AutoSize = true;
            this.lblMiscHeader.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMiscHeader.Location = new System.Drawing.Point(6, 29);
            this.lblMiscHeader.Name = "lblMiscHeader";
            this.lblMiscHeader.Size = new System.Drawing.Size(593, 12);
            this.lblMiscHeader.TabIndex = 0;
            this.lblMiscHeader.Text = "此处详细介绍了影响渲染过程和启用贴图修改的开关。将鼠标悬停在工具提示上时，工具提示会提供其他信息。";
            // 
            // gbMarkings
            // 
            this.gbMarkings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMarkings.Controls.Add(this.cbDiagnosticWindow);
            this.gbMarkings.Controls.Add(this.cbTunnelPosition);
            this.gbMarkings.Controls.Add(this.cbMarkIceGrowth);
            this.gbMarkings.Controls.Add(this.cbEmphasizeOre);
            this.gbMarkings.Controls.Add(this.cbTunnelPaths);
            this.gbMarkings.Location = new System.Drawing.Point(13, 227);
            this.gbMarkings.Name = "gbMarkings";
            this.gbMarkings.Size = new System.Drawing.Size(573, 96);
            this.gbMarkings.TabIndex = 3;
            this.gbMarkings.TabStop = false;
            this.gbMarkings.Text = "附加标记";
            // 
            // cbDiagnosticWindow
            // 
            this.cbDiagnosticWindow.AutoSize = true;
            this.cbDiagnosticWindow.Location = new System.Drawing.Point(13, 64);
            this.cbDiagnosticWindow.Name = "cbDiagnosticWindow";
            this.cbDiagnosticWindow.Size = new System.Drawing.Size(96, 16);
            this.cbDiagnosticWindow.TabIndex = 4;
            this.cbDiagnosticWindow.Text = "显示预览窗口";
            this.toolTip.SetToolTip(this.cbDiagnosticWindow, "显示诊断窗口");
            this.cbDiagnosticWindow.UseVisualStyleBackColor = true;
            this.cbDiagnosticWindow.CheckedChanged += new System.EventHandler(this.cbDiagnosticWindow_CheckedChanged);
            // 
            // cbTunnelPosition
            // 
            this.cbTunnelPosition.AutoSize = true;
            this.cbTunnelPosition.Checked = true;
            this.cbTunnelPosition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTunnelPosition.Enabled = false;
            this.cbTunnelPosition.Location = new System.Drawing.Point(195, 42);
            this.cbTunnelPosition.Name = "cbTunnelPosition";
            this.cbTunnelPosition.Size = new System.Drawing.Size(120, 16);
            this.cbTunnelPosition.TabIndex = 3;
            this.cbTunnelPosition.Text = "提高隧道线路高度";
            this.toolTip.SetToolTip(this.cbTunnelPosition, "将隧道线的高度提高4个单元格，以补偿隧道入口图形");
            this.cbTunnelPosition.UseVisualStyleBackColor = true;
            this.cbTunnelPosition.CheckedChanged += new System.EventHandler(this.cbTunnelPosition_CheckedChanged);
            // 
            // cbMarkIceGrowth
            // 
            this.cbMarkIceGrowth.AutoSize = true;
            this.cbMarkIceGrowth.Location = new System.Drawing.Point(195, 21);
            this.cbMarkIceGrowth.Name = "cbMarkIceGrowth";
            this.cbMarkIceGrowth.Size = new System.Drawing.Size(96, 16);
            this.cbMarkIceGrowth.TabIndex = 1;
            this.cbMarkIceGrowth.Text = "标记冰的生长";
            this.toolTip.SetToolTip(this.cbMarkIceGrowth, "标记具有冰生长设置的细胞，用于TS雪地地图");
            this.cbMarkIceGrowth.UseVisualStyleBackColor = true;
            this.cbMarkIceGrowth.CheckedChanged += new System.EventHandler(this.cbMarkIceGrowth_CheckedChanged);
            // 
            // cbEmphasizeOre
            // 
            this.cbEmphasizeOre.AutoSize = true;
            this.cbEmphasizeOre.Location = new System.Drawing.Point(13, 21);
            this.cbEmphasizeOre.Name = "cbEmphasizeOre";
            this.cbEmphasizeOre.Size = new System.Drawing.Size(96, 16);
            this.cbEmphasizeOre.TabIndex = 0;
            this.cbEmphasizeOre.Text = "强调资源字段";
            this.toolTip.SetToolTip(this.cbEmphasizeOre, "设置此选项将导致矿石后面出现黄色光晕，宝石后面出现紫色光晕。当缩小图像时，例如将其用作地图的小预览图像，这看起来非常好。");
            this.cbEmphasizeOre.UseVisualStyleBackColor = true;
            this.cbEmphasizeOre.CheckedChanged += new System.EventHandler(this.UIChanged);
            // 
            // cbTunnelPaths
            // 
            this.cbTunnelPaths.AutoSize = true;
            this.cbTunnelPaths.Location = new System.Drawing.Point(13, 42);
            this.cbTunnelPaths.Name = "cbTunnelPaths";
            this.cbTunnelPaths.Size = new System.Drawing.Size(96, 16);
            this.cbTunnelPaths.TabIndex = 2;
            this.cbTunnelPaths.Text = "显示隧道路径";
            this.toolTip.SetToolTip(this.cbTunnelPaths, "显示隧道路径线。");
            this.cbTunnelPaths.UseVisualStyleBackColor = true;
            this.cbTunnelPaths.CheckedChanged += new System.EventHandler(this.cbTunnelPaths_CheckedChanged);
            // 
            // gbStartMarkers
            // 
            this.gbStartMarkers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStartMarkers.Controls.Add(this.cbStartMarkers);
            this.gbStartMarkers.Controls.Add(this.lblMarkerSize);
            this.gbStartMarkers.Controls.Add(this.lblStartMarkerType);
            this.gbStartMarkers.Controls.Add(this.cbMarkerSize);
            this.gbStartMarkers.Controls.Add(this.cmbStartMarkers);
            this.gbStartMarkers.Controls.Add(this.lblSquaredStartPosDescription);
            this.gbStartMarkers.Location = new System.Drawing.Point(13, 54);
            this.gbStartMarkers.Name = "gbStartMarkers";
            this.gbStartMarkers.Size = new System.Drawing.Size(573, 78);
            this.gbStartMarkers.TabIndex = 1;
            this.gbStartMarkers.TabStop = false;
            this.gbStartMarkers.Text = "起始位置标记\n\n";
            // 
            // cbStartMarkers
            // 
            this.cbStartMarkers.AutoSize = true;
            this.cbStartMarkers.Location = new System.Drawing.Point(16, 45);
            this.cbStartMarkers.Name = "cbStartMarkers";
            this.cbStartMarkers.Size = new System.Drawing.Size(144, 16);
            this.cbStartMarkers.TabIndex = 1;
            this.cbStartMarkers.Text = "在起始位置放置标记。";
            this.cbStartMarkers.UseVisualStyleBackColor = true;
            this.cbStartMarkers.CheckedChanged += new System.EventHandler(this.cbStartMarkers_CheckedChanged);
            // 
            // lblMarkerSize
            // 
            this.lblMarkerSize.AutoSize = true;
            this.lblMarkerSize.Location = new System.Drawing.Point(455, 39);
            this.lblMarkerSize.Name = "lblMarkerSize";
            this.lblMarkerSize.Size = new System.Drawing.Size(53, 12);
            this.lblMarkerSize.TabIndex = 4;
            this.lblMarkerSize.Text = "标记大小";
            this.toolTip.SetToolTip(this.lblMarkerSize, "Shapes other than Tiled can use decimal input sizes.");
            // 
            // lblStartMarkerType
            // 
            this.lblStartMarkerType.AutoSize = true;
            this.lblStartMarkerType.Location = new System.Drawing.Point(357, 39);
            this.lblStartMarkerType.Name = "lblStartMarkerType";
            this.lblStartMarkerType.Size = new System.Drawing.Size(53, 12);
            this.lblStartMarkerType.TabIndex = 2;
            this.lblStartMarkerType.Text = "标记类型";
            // 
            // cbMarkerSize
            // 
            this.cbMarkerSize.FormattingEnabled = true;
            this.cbMarkerSize.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbMarkerSize.Location = new System.Drawing.Point(449, 54);
            this.cbMarkerSize.Name = "cbMarkerSize";
            this.cbMarkerSize.Size = new System.Drawing.Size(59, 20);
            this.cbMarkerSize.TabIndex = 5;
            this.cbMarkerSize.Text = "4";
            this.cbMarkerSize.SelectedIndexChanged += new System.EventHandler(this.cmbMarkerSize_SelectedIndexChanged);
            // 
            // cmbStartMarkers
            // 
            this.cmbStartMarkers.FormattingEnabled = true;
            this.cmbStartMarkers.Items.AddRange(new object[] {
            "None",
            "Squared",
            "Circled",
            "Diamond",
            "Ellipsed",
            "Starred",
            "Tiled"});
            this.cmbStartMarkers.Location = new System.Drawing.Point(341, 54);
            this.cmbStartMarkers.Name = "cmbStartMarkers";
            this.cmbStartMarkers.Size = new System.Drawing.Size(99, 20);
            this.cmbStartMarkers.TabIndex = 3;
            this.cmbStartMarkers.Text = "Diamond";
            this.cmbStartMarkers.SelectedIndexChanged += new System.EventHandler(this.cmbStartMarkers_SelectedIndexChanged);
            // 
            // lblSquaredStartPosDescription
            // 
            this.lblSquaredStartPosDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSquaredStartPosDescription.AutoSize = true;
            this.lblSquaredStartPosDescription.Location = new System.Drawing.Point(13, 21);
            this.lblSquaredStartPosDescription.Name = "lblSquaredStartPosDescription";
            this.lblSquaredStartPosDescription.Size = new System.Drawing.Size(365, 24);
            this.lblSquaredStartPosDescription.TabIndex = 0;
            this.lblSquaredStartPosDescription.Text = "平铺标记选项为平铺本身着色，而其他选项则在起始位置绘制标记。\n\n";
            // 
            // gbSizeMode
            // 
            this.gbSizeMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSizeMode.Controls.Add(this.rbSizeAuto);
            this.gbSizeMode.Controls.Add(this.rbSizeFullmap);
            this.gbSizeMode.Controls.Add(this.rbSizeLocal);
            this.gbSizeMode.Location = new System.Drawing.Point(13, 329);
            this.gbSizeMode.Name = "gbSizeMode";
            this.gbSizeMode.Size = new System.Drawing.Size(573, 47);
            this.gbSizeMode.TabIndex = 4;
            this.gbSizeMode.TabStop = false;
            this.gbSizeMode.Text = "大小调整模式";
            // 
            // rbSizeAuto
            // 
            this.rbSizeAuto.AutoSize = true;
            this.rbSizeAuto.Checked = true;
            this.rbSizeAuto.Location = new System.Drawing.Point(16, 19);
            this.rbSizeAuto.Name = "rbSizeAuto";
            this.rbSizeAuto.Size = new System.Drawing.Size(95, 16);
            this.rbSizeAuto.TabIndex = 0;
            this.rbSizeAuto.TabStop = true;
            this.rbSizeAuto.Text = "自动调整大小";
            this.toolTip.SetToolTip(this.rbSizeAuto, "Saves the portion of the map that is visible in game.");
            this.rbSizeAuto.UseVisualStyleBackColor = true;
            // 
            // rbSizeFullmap
            // 
            this.rbSizeFullmap.AutoSize = true;
            this.rbSizeFullmap.Location = new System.Drawing.Point(321, 19);
            this.rbSizeFullmap.Name = "rbSizeFullmap";
            this.rbSizeFullmap.Size = new System.Drawing.Size(167, 16);
            this.rbSizeFullmap.TabIndex = 2;
            this.rbSizeFullmap.Text = "使用全尺寸（对任务有用）";
            this.toolTip.SetToolTip(this.rbSizeFullmap, "保存整个地图，而不切断游戏中可见部分之外的部分。");
            this.rbSizeFullmap.UseVisualStyleBackColor = true;
            this.rbSizeFullmap.CheckedChanged += new System.EventHandler(this.UIChanged);
            // 
            // rbSizeLocal
            // 
            this.rbSizeLocal.AutoSize = true;
            this.rbSizeLocal.Location = new System.Drawing.Point(157, 19);
            this.rbSizeLocal.Name = "rbSizeLocal";
            this.rbSizeLocal.Size = new System.Drawing.Size(119, 16);
            this.rbSizeLocal.TabIndex = 1;
            this.rbSizeLocal.Text = "游戏中可见的部分";
            this.toolTip.SetToolTip(this.rbSizeLocal, "Saves the portion of the map that is visible in game.");
            this.rbSizeLocal.UseVisualStyleBackColor = true;
            this.rbSizeLocal.CheckedChanged += new System.EventHandler(this.UIChanged);
            // 
            // gbThumbs
            // 
            this.gbThumbs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbThumbs.Controls.Add(this.cbCompressTiles);
            this.gbThumbs.Controls.Add(this.lblMarkersType);
            this.gbThumbs.Controls.Add(this.cbFixOverlay);
            this.gbThumbs.Controls.Add(this.cbMarkersType);
            this.gbThumbs.Controls.Add(this.cbBackup);
            this.gbThumbs.Controls.Add(this.cbReplacePreview);
            this.gbThumbs.Controls.Add(this.ckbFixupTiles);
            this.gbThumbs.Location = new System.Drawing.Point(13, 138);
            this.gbThumbs.Name = "gbThumbs";
            this.gbThumbs.Size = new System.Drawing.Size(573, 84);
            this.gbThumbs.TabIndex = 2;
            this.gbThumbs.TabStop = false;
            this.gbThumbs.Text = "地图修改";
            // 
            // cbCompressTiles
            // 
            this.cbCompressTiles.AutoSize = true;
            this.cbCompressTiles.Location = new System.Drawing.Point(195, 42);
            this.cbCompressTiles.Name = "cbCompressTiles";
            this.cbCompressTiles.Size = new System.Drawing.Size(138, 16);
            this.cbCompressTiles.TabIndex = 4;
            this.cbCompressTiles.Text = "Compress Tiles Pack";
            this.toolTip.SetToolTip(this.cbCompressTiles, "压缩地图中的IsoMapPack5部分，由FinalSun或FinalAlert2撤消");
            this.cbCompressTiles.UseVisualStyleBackColor = true;
            this.cbCompressTiles.CheckedChanged += new System.EventHandler(this.cbCompressTiles_CheckedChanged);
            // 
            // lblMarkersType
            // 
            this.lblMarkersType.AutoSize = true;
            this.lblMarkersType.Location = new System.Drawing.Point(351, 21);
            this.lblMarkersType.Name = "lblMarkersType";
            this.lblMarkersType.Size = new System.Drawing.Size(89, 12);
            this.lblMarkersType.TabIndex = 1;
            this.lblMarkersType.Text = "起始位置标记：";
            // 
            // cbFixOverlay
            // 
            this.cbFixOverlay.AutoSize = true;
            this.cbFixOverlay.Location = new System.Drawing.Point(13, 64);
            this.cbFixOverlay.Name = "cbFixOverlay";
            this.cbFixOverlay.Size = new System.Drawing.Size(96, 16);
            this.cbFixOverlay.TabIndex = 5;
            this.cbFixOverlay.Text = "Fix Overlays";
            this.toolTip.SetToolTip(this.cbFixOverlay, "删除未定义的覆盖并覆盖地图中的覆盖部分");
            this.cbFixOverlay.UseVisualStyleBackColor = true;
            this.cbFixOverlay.CheckedChanged += new System.EventHandler(this.cbFixOverlay_CheckedChanged);
            // 
            // cbMarkersType
            // 
            this.cbMarkersType.FormattingEnabled = true;
            this.cbMarkersType.Items.AddRange(new object[] {
            "None",
            "SelectedAsAbove",
            "Aro",
            "Bittah"});
            this.cbMarkersType.Location = new System.Drawing.Point(449, 18);
            this.cbMarkersType.Name = "cbMarkersType";
            this.cbMarkersType.Size = new System.Drawing.Size(83, 20);
            this.cbMarkersType.TabIndex = 2;
            this.cbMarkersType.Text = "None";
            this.cbMarkersType.SelectedIndexChanged += new System.EventHandler(this.UIChanged);
            // 
            // cbBackup
            // 
            this.cbBackup.AutoSize = true;
            this.cbBackup.Checked = true;
            this.cbBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBackup.Location = new System.Drawing.Point(195, 64);
            this.cbBackup.Name = "cbBackup";
            this.cbBackup.Size = new System.Drawing.Size(72, 16);
            this.cbBackup.TabIndex = 6;
            this.cbBackup.Text = "备份地图";
            this.toolTip.SetToolTip(this.cbBackup, "修改地图文件时创建备份");
            this.cbBackup.UseVisualStyleBackColor = true;
            this.cbBackup.CheckedChanged += new System.EventHandler(this.cbBackup_CheckedChanged);
            // 
            // cbReplacePreview
            // 
            this.cbReplacePreview.AutoSize = true;
            this.cbReplacePreview.Location = new System.Drawing.Point(13, 21);
            this.cbReplacePreview.Name = "cbReplacePreview";
            this.cbReplacePreview.Size = new System.Drawing.Size(204, 16);
            this.cbReplacePreview.TabIndex = 0;
            this.cbReplacePreview.Text = "用结果图像的缩略图替换地图预览";
            this.toolTip.SetToolTip(this.cbReplacePreview, "FinalAlert2预览通常看起来很差。用缩小的");
            this.cbReplacePreview.UseVisualStyleBackColor = true;
            this.cbReplacePreview.CheckedChanged += new System.EventHandler(this.CbReplacePreviewCheckedChanged);
            // 
            // ckbFixupTiles
            // 
            this.ckbFixupTiles.AutoSize = true;
            this.ckbFixupTiles.Location = new System.Drawing.Point(13, 42);
            this.ckbFixupTiles.Name = "ckbFixupTiles";
            this.ckbFixupTiles.Size = new System.Drawing.Size(78, 16);
            this.ckbFixupTiles.TabIndex = 3;
            this.ckbFixupTiles.Text = "Fix Tiles";
            this.toolTip.SetToolTip(this.ckbFixupTiles, "删除未定义的Tiles并覆盖地图中的IsoMapPack5部分");
            this.ckbFixupTiles.UseVisualStyleBackColor = true;
            this.ckbFixupTiles.CheckedChanged += new System.EventHandler(this.UIChanged);
            // 
            // gbInputOutput
            // 
            this.gbInputOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbInputOutput.Controls.Add(this.gbFileName);
            this.gbInputOutput.Controls.Add(this.groupBox1);
            this.gbInputOutput.Controls.Add(this.gbModConfig);
            this.gbInputOutput.Controls.Add(this.gbImageFormat);
            this.gbInputOutput.Controls.Add(this.tbMixDir);
            this.gbInputOutput.Controls.Add(this.lblMixFiles);
            this.gbInputOutput.Controls.Add(this.btnBrowseMixDir);
            this.gbInputOutput.Controls.Add(this.tbInput);
            this.gbInputOutput.Controls.Add(this.lblInputMap);
            this.gbInputOutput.Controls.Add(this.btnBrowseInput);
            this.gbInputOutput.Location = new System.Drawing.Point(6, 6);
            this.gbInputOutput.Name = "gbInputOutput";
            this.gbInputOutput.Size = new System.Drawing.Size(590, 336);
            this.gbInputOutput.TabIndex = 0;
            this.gbInputOutput.TabStop = false;
            this.gbInputOutput.Text = "输入和输出设置";
            this.gbInputOutput.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputDragDrop);
            this.gbInputOutput.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputDragEnter);
            // 
            // gbFileName
            // 
            this.gbFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFileName.Controls.Add(this.rbUseFilename);
            this.gbFileName.Controls.Add(this.tbCustomOutput);
            this.gbFileName.Controls.Add(this.rbAutoFilename);
            this.gbFileName.Controls.Add(this.rbCustomFilename);
            this.gbFileName.Location = new System.Drawing.Point(13, 158);
            this.gbFileName.Name = "gbFileName";
            this.gbFileName.Size = new System.Drawing.Size(566, 50);
            this.gbFileName.TabIndex = 7;
            this.gbFileName.TabStop = false;
            this.gbFileName.Text = "输出文件名配置";
            // 
            // rbUseFilename
            // 
            this.rbUseFilename.AutoSize = true;
            this.rbUseFilename.Checked = true;
            this.rbUseFilename.Location = new System.Drawing.Point(13, 21);
            this.rbUseFilename.Name = "rbUseFilename";
            this.rbUseFilename.Size = new System.Drawing.Size(107, 16);
            this.rbUseFilename.TabIndex = 0;
            this.rbUseFilename.TabStop = true;
            this.rbUseFilename.Text = "使用地图文件名";
            this.toolTip.SetToolTip(this.rbUseFilename, "Use input filename for output");
            this.rbUseFilename.UseVisualStyleBackColor = true;
            this.rbUseFilename.CheckedChanged += new System.EventHandler(this.rbUseFilename_CheckedChanged);
            // 
            // tbCustomOutput
            // 
            this.tbCustomOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCustomOutput.Location = new System.Drawing.Point(304, 20);
            this.tbCustomOutput.Name = "tbCustomOutput";
            this.tbCustomOutput.Size = new System.Drawing.Size(251, 21);
            this.tbCustomOutput.TabIndex = 3;
            this.tbCustomOutput.TextChanged += new System.EventHandler(this.UIChanged);
            // 
            // rbAutoFilename
            // 
            this.rbAutoFilename.AutoSize = true;
            this.rbAutoFilename.Location = new System.Drawing.Point(126, 21);
            this.rbAutoFilename.Name = "rbAutoFilename";
            this.rbAutoFilename.Size = new System.Drawing.Size(71, 16);
            this.rbAutoFilename.TabIndex = 1;
            this.rbAutoFilename.TabStop = true;
            this.rbAutoFilename.Text = "自动生成";
            this.toolTip.SetToolTip(this.rbAutoFilename, resources.GetString("rbAutoFilename.ToolTip"));
            this.rbAutoFilename.UseVisualStyleBackColor = true;
            this.rbAutoFilename.CheckedChanged += new System.EventHandler(this.OutputNameCheckedChanged);
            // 
            // rbCustomFilename
            // 
            this.rbCustomFilename.AutoSize = true;
            this.rbCustomFilename.Location = new System.Drawing.Point(203, 21);
            this.rbCustomFilename.Name = "rbCustomFilename";
            this.rbCustomFilename.Size = new System.Drawing.Size(95, 16);
            this.rbCustomFilename.TabIndex = 2;
            this.rbCustomFilename.TabStop = true;
            this.rbCustomFilename.Text = "自定义文件名";
            this.toolTip.SetToolTip(this.rbCustomFilename, "Overrides the output name with the given name by user. \r\nThe .jpg and .png extens" +
        "ions are automatically added.");
            this.rbCustomFilename.UseVisualStyleBackColor = true;
            this.rbCustomFilename.CheckedChanged += new System.EventHandler(this.OutputNameCheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbEngineFS);
            this.groupBox1.Controls.Add(this.lbEngine);
            this.groupBox1.Controls.Add(this.rbEngineTS);
            this.groupBox1.Controls.Add(this.rbEngineAuto);
            this.groupBox1.Controls.Add(this.rbEngineYR);
            this.groupBox1.Controls.Add(this.rbEngineRA2);
            this.groupBox1.Location = new System.Drawing.Point(13, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 63);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "地图版本设置";
            // 
            // rbEngineFS
            // 
            this.rbEngineFS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbEngineFS.AutoSize = true;
            this.rbEngineFS.Location = new System.Drawing.Point(385, 37);
            this.rbEngineFS.Name = "rbEngineFS";
            this.rbEngineFS.Size = new System.Drawing.Size(65, 16);
            this.rbEngineFS.TabIndex = 5;
            this.rbEngineFS.TabStop = true;
            this.rbEngineFS.Text = "使用 FS";
            this.rbEngineFS.UseVisualStyleBackColor = true;
            this.rbEngineFS.CheckedChanged += new System.EventHandler(this.RbEngineCheckedChanged);
            // 
            // lbEngine
            // 
            this.lbEngine.Location = new System.Drawing.Point(12, 19);
            this.lbEngine.Name = "lbEngine";
            this.lbEngine.Size = new System.Drawing.Size(487, 15);
            this.lbEngine.TabIndex = 0;
            this.lbEngine.Text = "这指示程序要模拟哪个游戏版本。选择不兼容的会导致崩溃。";
            // 
            // rbEngineTS
            // 
            this.rbEngineTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbEngineTS.AutoSize = true;
            this.rbEngineTS.Location = new System.Drawing.Point(294, 37);
            this.rbEngineTS.Name = "rbEngineTS";
            this.rbEngineTS.Size = new System.Drawing.Size(65, 16);
            this.rbEngineTS.TabIndex = 4;
            this.rbEngineTS.TabStop = true;
            this.rbEngineTS.Text = "使用 TS";
            this.rbEngineTS.UseVisualStyleBackColor = true;
            this.rbEngineTS.CheckedChanged += new System.EventHandler(this.RbEngineCheckedChanged);
            // 
            // rbEngineAuto
            // 
            this.rbEngineAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbEngineAuto.AutoSize = true;
            this.rbEngineAuto.Checked = true;
            this.rbEngineAuto.Location = new System.Drawing.Point(13, 37);
            this.rbEngineAuto.Name = "rbEngineAuto";
            this.rbEngineAuto.Size = new System.Drawing.Size(71, 16);
            this.rbEngineAuto.TabIndex = 1;
            this.rbEngineAuto.TabStop = true;
            this.rbEngineAuto.Text = "自动检测";
            this.toolTip.SetToolTip(this.rbEngineAuto, resources.GetString("rbEngineAuto.ToolTip"));
            this.rbEngineAuto.UseVisualStyleBackColor = true;
            this.rbEngineAuto.CheckedChanged += new System.EventHandler(this.RbEngineCheckedChanged);
            // 
            // rbEngineYR
            // 
            this.rbEngineYR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbEngineYR.AutoSize = true;
            this.rbEngineYR.Location = new System.Drawing.Point(110, 37);
            this.rbEngineYR.Name = "rbEngineYR";
            this.rbEngineYR.Size = new System.Drawing.Size(65, 16);
            this.rbEngineYR.TabIndex = 2;
            this.rbEngineYR.TabStop = true;
            this.rbEngineYR.Text = "使用 YR";
            this.rbEngineYR.UseVisualStyleBackColor = true;
            this.rbEngineYR.CheckedChanged += new System.EventHandler(this.RbEngineCheckedChanged);
            // 
            // rbEngineRA2
            // 
            this.rbEngineRA2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbEngineRA2.AutoSize = true;
            this.rbEngineRA2.Location = new System.Drawing.Point(200, 37);
            this.rbEngineRA2.Name = "rbEngineRA2";
            this.rbEngineRA2.Size = new System.Drawing.Size(71, 16);
            this.rbEngineRA2.TabIndex = 3;
            this.rbEngineRA2.TabStop = true;
            this.rbEngineRA2.Text = "使用 RA2";
            this.rbEngineRA2.UseVisualStyleBackColor = true;
            this.rbEngineRA2.CheckedChanged += new System.EventHandler(this.RbEngineCheckedChanged);
            // 
            // gbModConfig
            // 
            this.gbModConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbModConfig.Controls.Add(this.btnModEditor);
            this.gbModConfig.Controls.Add(this.tbModConfig);
            this.gbModConfig.Controls.Add(this.ckbModConfig);
            this.gbModConfig.Location = new System.Drawing.Point(13, 279);
            this.gbModConfig.Name = "gbModConfig";
            this.gbModConfig.Size = new System.Drawing.Size(566, 39);
            this.gbModConfig.TabIndex = 9;
            this.gbModConfig.TabStop = false;
            // 
            // btnModEditor
            // 
            this.btnModEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModEditor.Location = new System.Drawing.Point(486, 12);
            this.btnModEditor.Name = "btnModEditor";
            this.btnModEditor.Size = new System.Drawing.Size(75, 21);
            this.btnModEditor.TabIndex = 2;
            this.btnModEditor.Text = "选择文件";
            this.btnModEditor.UseVisualStyleBackColor = true;
            this.btnModEditor.Click += new System.EventHandler(this.BtnModEditorClick);
            // 
            // tbModConfig
            // 
            this.tbModConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbModConfig.Location = new System.Drawing.Point(139, 12);
            this.tbModConfig.Name = "tbModConfig";
            this.tbModConfig.Size = new System.Drawing.Size(341, 21);
            this.tbModConfig.TabIndex = 1;
            this.tbModConfig.TextChanged += new System.EventHandler(this.UIChanged);
            // 
            // ckbModConfig
            // 
            this.ckbModConfig.AutoSize = true;
            this.ckbModConfig.Location = new System.Drawing.Point(8, 14);
            this.ckbModConfig.Name = "ckbModConfig";
            this.ckbModConfig.Size = new System.Drawing.Size(126, 16);
            this.ckbModConfig.TabIndex = 0;
            this.ckbModConfig.Text = "加载特殊的mod配置";
            this.toolTip.SetToolTip(this.ckbModConfig, "Special mod configs allow you to specify precisely which extra directories, mixes" +
        "\r\nand theater specific settings should be considered for your mod.");
            this.ckbModConfig.UseVisualStyleBackColor = true;
            this.ckbModConfig.CheckedChanged += new System.EventHandler(this.cbModConfig_CheckedChanged);
            // 
            // gbImageFormat
            // 
            this.gbImageFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbImageFormat.Controls.Add(this.lblThumbSize);
            this.gbImageFormat.Controls.Add(this.cbThumbPNG);
            this.gbImageFormat.Controls.Add(this.cbPreserveThumbAspect);
            this.gbImageFormat.Controls.Add(this.tbThumbDimensions);
            this.gbImageFormat.Controls.Add(this.cbOutputThumbnail);
            this.gbImageFormat.Controls.Add(this.lblQuality);
            this.gbImageFormat.Controls.Add(this.lblCompressionLevel);
            this.gbImageFormat.Controls.Add(this.nudEncodingQuality);
            this.gbImageFormat.Controls.Add(this.cbOutputJPG);
            this.gbImageFormat.Controls.Add(this.cbOutputPNG);
            this.gbImageFormat.Controls.Add(this.nudCompression);
            this.gbImageFormat.Location = new System.Drawing.Point(13, 62);
            this.gbImageFormat.Name = "gbImageFormat";
            this.gbImageFormat.Size = new System.Drawing.Size(566, 90);
            this.gbImageFormat.TabIndex = 6;
            this.gbImageFormat.TabStop = false;
            this.gbImageFormat.Text = "图片输出格式";
            // 
            // lblThumbSize
            // 
            this.lblThumbSize.AutoSize = true;
            this.lblThumbSize.Location = new System.Drawing.Point(243, 67);
            this.lblThumbSize.Name = "lblThumbSize";
            this.lblThumbSize.Size = new System.Drawing.Size(65, 12);
            this.lblThumbSize.TabIndex = 8;
            this.lblThumbSize.Text = "缩略图大小";
            // 
            // cbThumbPNG
            // 
            this.cbThumbPNG.AutoSize = true;
            this.cbThumbPNG.Checked = true;
            this.cbThumbPNG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbThumbPNG.Location = new System.Drawing.Point(146, 66);
            this.cbThumbPNG.Name = "cbThumbPNG";
            this.cbThumbPNG.Size = new System.Drawing.Size(72, 16);
            this.cbThumbPNG.TabIndex = 7;
            this.cbThumbPNG.Text = "输出 PNG";
            this.toolTip.SetToolTip(this.cbThumbPNG, "Save generated thumbnails as PNG images, instead of JPEG.");
            this.cbThumbPNG.UseVisualStyleBackColor = true;
            this.cbThumbPNG.CheckedChanged += new System.EventHandler(this.UIChanged);
            // 
            // cbPreserveThumbAspect
            // 
            this.cbPreserveThumbAspect.AutoSize = true;
            this.cbPreserveThumbAspect.Checked = true;
            this.cbPreserveThumbAspect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPreserveThumbAspect.Location = new System.Drawing.Point(432, 66);
            this.cbPreserveThumbAspect.Name = "cbPreserveThumbAspect";
            this.cbPreserveThumbAspect.Size = new System.Drawing.Size(84, 16);
            this.cbPreserveThumbAspect.TabIndex = 10;
            this.cbPreserveThumbAspect.Text = "保持纵横比";
            this.toolTip.SetToolTip(this.cbPreserveThumbAspect, resources.GetString("cbPreserveThumbAspect.ToolTip"));
            this.cbPreserveThumbAspect.UseVisualStyleBackColor = true;
            this.cbPreserveThumbAspect.CheckedChanged += new System.EventHandler(this.UIChanged);
            // 
            // tbThumbDimensions
            // 
            this.tbThumbDimensions.Location = new System.Drawing.Point(326, 65);
            this.tbThumbDimensions.Name = "tbThumbDimensions";
            this.tbThumbDimensions.Size = new System.Drawing.Size(100, 21);
            this.tbThumbDimensions.TabIndex = 9;
            this.tbThumbDimensions.Text = "800,0";
            // 
            // cbOutputThumbnail
            // 
            this.cbOutputThumbnail.AutoSize = true;
            this.cbOutputThumbnail.Location = new System.Drawing.Point(13, 66);
            this.cbOutputThumbnail.Name = "cbOutputThumbnail";
            this.cbOutputThumbnail.Size = new System.Drawing.Size(84, 16);
            this.cbOutputThumbnail.TabIndex = 6;
            this.cbOutputThumbnail.Text = "生成缩略图";
            this.toolTip.SetToolTip(this.cbOutputThumbnail, resources.GetString("cbOutputThumbnail.ToolTip"));
            this.cbOutputThumbnail.UseVisualStyleBackColor = true;
            this.cbOutputThumbnail.CheckedChanged += new System.EventHandler(this.CbOutputThumbnailCheckedChanged);
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Location = new System.Drawing.Point(104, 22);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(29, 12);
            this.lblQuality.TabIndex = 1;
            this.lblQuality.Text = "质量";
            this.toolTip.SetToolTip(this.lblQuality, "JPEG encoding quality, between 1-100 with 100 resulting in the largest file in th" +
        "e highest quality.");
            // 
            // lblCompressionLevel
            // 
            this.lblCompressionLevel.AutoSize = true;
            this.lblCompressionLevel.Location = new System.Drawing.Point(104, 48);
            this.lblCompressionLevel.Name = "lblCompressionLevel";
            this.lblCompressionLevel.Size = new System.Drawing.Size(53, 12);
            this.lblCompressionLevel.TabIndex = 4;
            this.lblCompressionLevel.Text = "压缩级别";
            this.toolTip.SetToolTip(this.lblCompressionLevel, "PNG compression level ranging from 1-9, 9 resulting in the smallest file but also" +
        " in longest loading time.");
            // 
            // nudEncodingQuality
            // 
            this.nudEncodingQuality.Location = new System.Drawing.Point(139, 20);
            this.nudEncodingQuality.Name = "nudEncodingQuality";
            this.nudEncodingQuality.Size = new System.Drawing.Size(43, 21);
            this.nudEncodingQuality.TabIndex = 2;
            this.nudEncodingQuality.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudEncodingQuality.ValueChanged += new System.EventHandler(this.UIChanged);
            // 
            // cbOutputJPG
            // 
            this.cbOutputJPG.AutoSize = true;
            this.cbOutputJPG.Location = new System.Drawing.Point(13, 21);
            this.cbOutputJPG.Name = "cbOutputJPG";
            this.cbOutputJPG.Size = new System.Drawing.Size(72, 16);
            this.cbOutputJPG.TabIndex = 0;
            this.cbOutputJPG.Text = "输出 JPG";
            this.toolTip.SetToolTip(this.cbOutputJPG, "Specifies whether or not a JPEG compressed image is saved.\r\nImages are always sav" +
        "ed in the same directory as the input map.");
            this.cbOutputJPG.UseVisualStyleBackColor = true;
            this.cbOutputJPG.CheckedChanged += new System.EventHandler(this.JpegOutputCheckedChanged);
            // 
            // cbOutputPNG
            // 
            this.cbOutputPNG.AutoSize = true;
            this.cbOutputPNG.Checked = true;
            this.cbOutputPNG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOutputPNG.Location = new System.Drawing.Point(13, 44);
            this.cbOutputPNG.Name = "cbOutputPNG";
            this.cbOutputPNG.Size = new System.Drawing.Size(72, 16);
            this.cbOutputPNG.TabIndex = 3;
            this.cbOutputPNG.Text = "输出 PNG";
            this.toolTip.SetToolTip(this.cbOutputPNG, "Specifies whether or not a PNG compressed image is saved.");
            this.cbOutputPNG.UseVisualStyleBackColor = true;
            this.cbOutputPNG.CheckedChanged += new System.EventHandler(this.PngOutputCheckedChanged);
            // 
            // nudCompression
            // 
            this.nudCompression.Location = new System.Drawing.Point(163, 43);
            this.nudCompression.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudCompression.Name = "nudCompression";
            this.nudCompression.Size = new System.Drawing.Size(43, 21);
            this.nudCompression.TabIndex = 5;
            this.nudCompression.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudCompression.ValueChanged += new System.EventHandler(this.UIChanged);
            // 
            // tbMixDir
            // 
            this.tbMixDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMixDir.Location = new System.Drawing.Point(96, 41);
            this.tbMixDir.Name = "tbMixDir";
            this.tbMixDir.Size = new System.Drawing.Size(397, 21);
            this.tbMixDir.TabIndex = 4;
            this.tbMixDir.TextChanged += new System.EventHandler(this.UIChanged);
            // 
            // lblMixFiles
            // 
            this.lblMixFiles.AutoSize = true;
            this.lblMixFiles.Location = new System.Drawing.Point(33, 44);
            this.lblMixFiles.Name = "lblMixFiles";
            this.lblMixFiles.Size = new System.Drawing.Size(53, 12);
            this.lblMixFiles.TabIndex = 3;
            this.lblMixFiles.Text = "游戏目录";
            this.toolTip.SetToolTip(this.lblMixFiles, "Set this to the folder where you have your game mix files stored.\r\nIf possible, t" +
        "his will be determined from information in the registry,\r\nmeaning you can leave " +
        "this empty.");
            // 
            // btnBrowseMixDir
            // 
            this.btnBrowseMixDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseMixDir.Location = new System.Drawing.Point(501, 42);
            this.btnBrowseMixDir.Name = "btnBrowseMixDir";
            this.btnBrowseMixDir.Size = new System.Drawing.Size(75, 21);
            this.btnBrowseMixDir.TabIndex = 5;
            this.btnBrowseMixDir.Text = "选择目录";
            this.btnBrowseMixDir.UseVisualStyleBackColor = true;
            this.btnBrowseMixDir.Click += new System.EventHandler(this.BrowseMixDir);
            // 
            // tbInput
            // 
            this.tbInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInput.Location = new System.Drawing.Point(96, 17);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(397, 21);
            this.tbInput.TabIndex = 1;
            this.tbInput.TextChanged += new System.EventHandler(this.UIChanged);
            // 
            // lblInputMap
            // 
            this.lblInputMap.AutoSize = true;
            this.lblInputMap.Location = new System.Drawing.Point(33, 23);
            this.lblInputMap.Name = "lblInputMap";
            this.lblInputMap.Size = new System.Drawing.Size(53, 12);
            this.lblInputMap.TabIndex = 0;
            this.lblInputMap.Text = "地图文件";
            this.toolTip.SetToolTip(this.lblInputMap, "Full path the to input map.\r\nValid filetypes are *.mpr, *.map, *.yrm, *.mmx, *.yr" +
        "o.");
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseInput.Location = new System.Drawing.Point(501, 17);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(75, 22);
            this.btnBrowseInput.TabIndex = 2;
            this.btnBrowseInput.Text = "选择文件";
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.BrowseInput);
            // 
            // btnRenderExecute
            // 
            this.btnRenderExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRenderExecute.Location = new System.Drawing.Point(499, 374);
            this.btnRenderExecute.Name = "btnRenderExecute";
            this.btnRenderExecute.Size = new System.Drawing.Size(75, 21);
            this.btnRenderExecute.TabIndex = 3;
            this.btnRenderExecute.Text = "开始渲染";
            this.btnRenderExecute.UseVisualStyleBackColor = true;
            this.btnRenderExecute.Click += new System.EventHandler(this.ExecuteCommand);
            // 
            // tbCommandPreview
            // 
            this.tbCommandPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCommandPreview.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbCommandPreview.Location = new System.Drawing.Point(73, 347);
            this.tbCommandPreview.Multiline = true;
            this.tbCommandPreview.Name = "tbCommandPreview";
            this.tbCommandPreview.ReadOnly = true;
            this.tbCommandPreview.Size = new System.Drawing.Size(410, 48);
            this.tbCommandPreview.TabIndex = 2;
            this.toolTip.SetToolTip(this.tbCommandPreview, "For more fine-grained control you can invoke CNCMaps.Renderer.exe manually!");
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblFill,
            this.pbProgress});
            this.statusStrip.Location = new System.Drawing.Point(0, 440);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(615, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 17);
            this.lblStatus.Text = "Status:";
            // 
            // lblFill
            // 
            this.lblFill.Name = "lblFill";
            this.lblFill.Size = new System.Drawing.Size(452, 17);
            this.lblFill.Spring = true;
            // 
            // pbProgress
            // 
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(100, 16);
            this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // lblBatchMapList
            // 
            this.lblBatchMapList.AutoSize = true;
            this.lblBatchMapList.Location = new System.Drawing.Point(13, 75);
            this.lblBatchMapList.Name = "lblBatchMapList";
            this.lblBatchMapList.Size = new System.Drawing.Size(53, 12);
            this.lblBatchMapList.TabIndex = 3;
            this.lblBatchMapList.Text = "地图列表";
            this.toolTip.SetToolTip(this.lblBatchMapList, "Full paths the to input maps.\r\nValid filetypes are *.mpr, *.map, *.yrm, *.mmx, *." +
        "yro.");
            // 
            // tabControl
            // 
            this.tabControl.AllowDrop = true;
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tpMain);
            this.tabControl.Controls.Add(this.tpMisc);
            this.tabControl.Controls.Add(this.tpBatch);
            this.tabControl.Controls.Add(this.tpLog);
            this.tabControl.Controls.Add(this.tpAbout);
            this.tabControl.Location = new System.Drawing.Point(3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(612, 425);
            this.tabControl.TabIndex = 0;
            this.tabControl.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputDragDrop);
            this.tabControl.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputDragEnter);
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.lblCommand);
            this.tpMain.Controls.Add(this.gbInputOutput);
            this.tpMain.Controls.Add(this.btnRenderExecute);
            this.tpMain.Controls.Add(this.tbCommandPreview);
            this.tpMain.Location = new System.Drawing.Point(4, 22);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Windows.Forms.Padding(3);
            this.tpMain.Size = new System.Drawing.Size(604, 399);
            this.tpMain.TabIndex = 0;
            this.tpMain.Text = "主要设置";
            this.tpMain.UseVisualStyleBackColor = true;
            // 
            // lblCommand
            // 
            this.lblCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(13, 359);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(29, 12);
            this.lblCommand.TabIndex = 1;
            this.lblCommand.Text = "命令";
            // 
            // tpMisc
            // 
            this.tpMisc.Controls.Add(this.gbMiscOptions);
            this.tpMisc.Location = new System.Drawing.Point(4, 22);
            this.tpMisc.Name = "tpMisc";
            this.tpMisc.Padding = new System.Windows.Forms.Padding(3);
            this.tpMisc.Size = new System.Drawing.Size(604, 399);
            this.tpMisc.TabIndex = 1;
            this.tpMisc.Text = "杂项设置";
            this.tpMisc.UseVisualStyleBackColor = true;
            // 
            // tpBatch
            // 
            this.tpBatch.Controls.Add(this.gbBatchRender);
            this.tpBatch.Location = new System.Drawing.Point(4, 22);
            this.tpBatch.Name = "tpBatch";
            this.tpBatch.Padding = new System.Windows.Forms.Padding(3);
            this.tpBatch.Size = new System.Drawing.Size(604, 399);
            this.tpBatch.TabIndex = 4;
            this.tpBatch.Text = "批量处理";
            this.tpBatch.UseVisualStyleBackColor = true;
            // 
            // gbBatchRender
            // 
            this.gbBatchRender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBatchRender.Controls.Add(this.btnBatchRender);
            this.gbBatchRender.Controls.Add(this.btnClearList);
            this.gbBatchRender.Controls.Add(this.lblBatchDesc);
            this.gbBatchRender.Controls.Add(this.tbBatchInput);
            this.gbBatchRender.Controls.Add(this.lblBatchMapList);
            this.gbBatchRender.Controls.Add(this.btnBrowseMaps);
            this.gbBatchRender.Location = new System.Drawing.Point(6, 6);
            this.gbBatchRender.Name = "gbBatchRender";
            this.gbBatchRender.Size = new System.Drawing.Size(592, 385);
            this.gbBatchRender.TabIndex = 0;
            this.gbBatchRender.TabStop = false;
            this.gbBatchRender.Text = "批量处理";
            this.gbBatchRender.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputDragDrop);
            this.gbBatchRender.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputDragEnter);
            // 
            // btnBatchRender
            // 
            this.btnBatchRender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatchRender.Location = new System.Drawing.Point(474, 358);
            this.btnBatchRender.Name = "btnBatchRender";
            this.btnBatchRender.Size = new System.Drawing.Size(112, 21);
            this.btnBatchRender.TabIndex = 5;
            this.btnBatchRender.Text = "开始批量处理";
            this.btnBatchRender.UseVisualStyleBackColor = true;
            this.btnBatchRender.Click += new System.EventHandler(this.BtnBatchRender_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearList.Location = new System.Drawing.Point(511, 65);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 19);
            this.btnClearList.TabIndex = 2;
            this.btnClearList.Text = "清空列表";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.BtnClearList_Click);
            // 
            // lblBatchDesc
            // 
            this.lblBatchDesc.Location = new System.Drawing.Point(13, 21);
            this.lblBatchDesc.Name = "lblBatchDesc";
            this.lblBatchDesc.Size = new System.Drawing.Size(566, 44);
            this.lblBatchDesc.TabIndex = 0;
            this.lblBatchDesc.Text = "批量渲染可用于处理具有标识设置的同一游戏/模式的多个地图。首先在“主要设置”和“杂项设置”选项卡上配置所需设置，然后通过“添加地图”按钮或拖放下面字段中的文件添加" +
    "所需地图。最后，按下“开始批量处理”按钮。";
            // 
            // tbBatchInput
            // 
            this.tbBatchInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBatchInput.Location = new System.Drawing.Point(13, 90);
            this.tbBatchInput.Multiline = true;
            this.tbBatchInput.Name = "tbBatchInput";
            this.tbBatchInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbBatchInput.Size = new System.Drawing.Size(566, 265);
            this.tbBatchInput.TabIndex = 4;
            // 
            // btnBrowseMaps
            // 
            this.btnBrowseMaps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseMaps.Location = new System.Drawing.Point(430, 65);
            this.btnBrowseMaps.Name = "btnBrowseMaps";
            this.btnBrowseMaps.Size = new System.Drawing.Size(75, 19);
            this.btnBrowseMaps.TabIndex = 1;
            this.btnBrowseMaps.Text = "添加地图";
            this.btnBrowseMaps.UseVisualStyleBackColor = true;
            this.btnBrowseMaps.Click += new System.EventHandler(this.BtnAddMaps_Click);
            // 
            // tpLog
            // 
            this.tpLog.Controls.Add(this.gbLog);
            this.tpLog.Location = new System.Drawing.Point(4, 22);
            this.tpLog.Name = "tpLog";
            this.tpLog.Size = new System.Drawing.Size(604, 399);
            this.tpLog.TabIndex = 2;
            this.tpLog.Text = "日志";
            this.tpLog.UseVisualStyleBackColor = true;
            // 
            // gbLog
            // 
            this.gbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLog.Controls.Add(this.btnClearLog);
            this.gbLog.Controls.Add(this.rtbLog);
            this.gbLog.Location = new System.Drawing.Point(6, 6);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(590, 388);
            this.gbLog.TabIndex = 0;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "日志";
            // 
            // btnClearLog
            // 
            this.btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearLog.Location = new System.Drawing.Point(520, 362);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(64, 20);
            this.btnClearLog.TabIndex = 1;
            this.btnClearLog.Text = "清空日志";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.BackColor = System.Drawing.Color.White;
            this.rtbLog.Location = new System.Drawing.Point(13, 21);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbLog.Size = new System.Drawing.Size(571, 336);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            this.rtbLog.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbLog_LinkClicked);
            // 
            // tpAbout
            // 
            this.tpAbout.AllowDrop = true;
            this.tpAbout.Controls.Add(this.btnCheckForUpdate);
            this.tpAbout.Controls.Add(this.ckbCheckForUpdates);
            this.tpAbout.Controls.Add(this.lblCopyright);
            this.tpAbout.Location = new System.Drawing.Point(4, 22);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbout.Size = new System.Drawing.Size(604, 399);
            this.tpAbout.TabIndex = 3;
            this.tpAbout.Text = "关于";
            this.tpAbout.UseVisualStyleBackColor = true;
            // 
            // btnCheckForUpdate
            // 
            this.btnCheckForUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckForUpdate.Location = new System.Drawing.Point(242, 358);
            this.btnCheckForUpdate.Name = "btnCheckForUpdate";
            this.btnCheckForUpdate.Size = new System.Drawing.Size(91, 21);
            this.btnCheckForUpdate.TabIndex = 2;
            this.btnCheckForUpdate.Text = "Check now";
            this.btnCheckForUpdate.UseVisualStyleBackColor = true;
            this.btnCheckForUpdate.Click += new System.EventHandler(this.btnCheckForUpdate_Click);
            // 
            // ckbCheckForUpdates
            // 
            this.ckbCheckForUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckbCheckForUpdates.AutoSize = true;
            this.ckbCheckForUpdates.Location = new System.Drawing.Point(20, 362);
            this.ckbCheckForUpdates.Name = "ckbCheckForUpdates";
            this.ckbCheckForUpdates.Size = new System.Drawing.Size(252, 16);
            this.ckbCheckForUpdates.TabIndex = 1;
            this.ckbCheckForUpdates.Text = "Check for updates on application start";
            this.ckbCheckForUpdates.UseVisualStyleBackColor = true;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.LinkArea = new System.Windows.Forms.LinkArea(131, 58);
            this.lblCopyright.Location = new System.Drawing.Point(20, 22);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(443, 142);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.TabStop = true;
            this.lblCopyright.Text = resources.GetString("lblCopyright.Text");
            this.lblCopyright.UseCompatibleTextRendering = true;
            this.lblCopyright.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCopyright_LinkClicked);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 462);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(631, 501);
            this.Name = "MainForm";
            this.Text = "红警地图渲染器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.InputDragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.InputDragEnter);
            this.gbMiscOptions.ResumeLayout(false);
            this.gbMiscOptions.PerformLayout();
            this.gbMarkings.ResumeLayout(false);
            this.gbMarkings.PerformLayout();
            this.gbStartMarkers.ResumeLayout(false);
            this.gbStartMarkers.PerformLayout();
            this.gbSizeMode.ResumeLayout(false);
            this.gbSizeMode.PerformLayout();
            this.gbThumbs.ResumeLayout(false);
            this.gbThumbs.PerformLayout();
            this.gbInputOutput.ResumeLayout(false);
            this.gbInputOutput.PerformLayout();
            this.gbFileName.ResumeLayout(false);
            this.gbFileName.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbModConfig.ResumeLayout(false);
            this.gbModConfig.PerformLayout();
            this.gbImageFormat.ResumeLayout(false);
            this.gbImageFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEncodingQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCompression)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.tpMain.PerformLayout();
            this.tpMisc.ResumeLayout(false);
            this.tpBatch.ResumeLayout(false);
            this.gbBatchRender.ResumeLayout(false);
            this.gbBatchRender.PerformLayout();
            this.tpLog.ResumeLayout(false);
            this.gbLog.ResumeLayout(false);
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbMiscOptions;
		private System.Windows.Forms.CheckBox cbEmphasizeOre;
		private System.Windows.Forms.GroupBox gbInputOutput;
		private System.Windows.Forms.Button btnBrowseInput;
		private System.Windows.Forms.TextBox tbMixDir;
		private System.Windows.Forms.Label lblMixFiles;
		private System.Windows.Forms.Button btnBrowseMixDir;
		private System.Windows.Forms.TextBox tbInput;
		private System.Windows.Forms.Label lblInputMap;
		private System.Windows.Forms.Button btnRenderExecute;
		private System.Windows.Forms.TextBox tbCommandPreview;
		private System.Windows.Forms.OpenFileDialog ofd;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
		private System.Windows.Forms.TextBox tbCustomOutput;
		private System.Windows.Forms.RadioButton rbCustomFilename;
		private System.Windows.Forms.RadioButton rbAutoFilename;
		private System.Windows.Forms.Label lblQuality;
		private System.Windows.Forms.Label lblCompressionLevel;
		private System.Windows.Forms.NumericUpDown nudEncodingQuality;
		private System.Windows.Forms.CheckBox cbOutputJPG;
		private System.Windows.Forms.CheckBox cbOutputPNG;
		private System.Windows.Forms.NumericUpDown nudCompression;
		private System.Windows.Forms.RadioButton rbSizeLocal;
		private System.Windows.Forms.RadioButton rbSizeFullmap;
		private System.Windows.Forms.CheckBox cbReplacePreview;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel lblFill;
		private System.Windows.Forms.ToolStripProgressBar pbProgress;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
		private System.Windows.Forms.TextBox tbModConfig;
		private System.Windows.Forms.CheckBox ckbModConfig;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.Button btnModEditor;
		private System.Windows.Forms.TabPage tpMisc;
		private System.Windows.Forms.TabPage tpMain;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.RadioButton rbSizeAuto;
		private System.Windows.Forms.Label lblCommand;
		private System.Windows.Forms.GroupBox gbThumbs;
		private CheckBox cbOutputThumbnail;
		private TextBox tbThumbDimensions;
		private CheckBox cbPreserveThumbAspect;
		private TabPage tpLog;
		private GroupBox gbLog;
		private RichTextBox rtbLog;
		private TabPage tpAbout;
		private ComboBox cbMarkersType;
		private Label lblMarkersType;
		private LinkLabel lblCopyright;
		private CheckBox ckbFixupTiles;
		private GroupBox gbSizeMode;
		private CheckBox cbThumbPNG;
		private RadioButton rbUseFilename;
		private CheckBox cbDiagnosticWindow;
		private CheckBox cbMarkIceGrowth;
		private CheckBox cbBackup;
		private CheckBox cbCompressTiles;
		private CheckBox cbFixOverlay;
		private CheckBox cbTunnelPaths;
		private CheckBox cbTunnelPosition;
		private RadioButton rbEngineFS;
		private RadioButton rbEngineTS;
		private RadioButton rbEngineAuto;
		private RadioButton rbEngineRA2;
		private RadioButton rbEngineYR;
		private Label lbEngine;
		private GroupBox gbModConfig;
		private GroupBox gbImageFormat;
		private Button btnClearLog;
		private GroupBox gbStartMarkers;
		private Label lblMarkerSize;
		private Label lblStartMarkerType;
		private ComboBox cbMarkerSize;
		private ComboBox cmbStartMarkers;
		private Label lblSquaredStartPosDescription;
		private CheckBox cbStartMarkers;
		private GroupBox gbMarkings;
		private TabPage tpBatch;
		private GroupBox gbBatchRender;
		private Label lblBatchDesc;
		private TextBox tbBatchInput;
		private Label lblBatchMapList;
		private Button btnBrowseMaps;
		private Button btnClearList;
		private Button btnBatchRender;
		private Button btnCheckForUpdate;
		private CheckBox ckbCheckForUpdates;
		private GroupBox gbFileName;
		private GroupBox groupBox1;
		private Label lblThumbSize;
		private Label lblMiscHeader;
	}
}

