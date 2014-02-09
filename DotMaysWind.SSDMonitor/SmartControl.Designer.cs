namespace DotMaysWind.SSDMonitor
{
    partial class SmartControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartControl));
            this.lvSmart = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCurrent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chWorst = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chThreshold = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRawData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvSmart
            // 
            this.lvSmart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chCurrent,
            this.chWorst,
            this.chThreshold,
            this.chRawData,
            this.chStatus});
            resources.ApplyResources(this.lvSmart, "lvSmart");
            this.lvSmart.FullRowSelect = true;
            this.lvSmart.GridLines = true;
            this.lvSmart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSmart.MultiSelect = false;
            this.lvSmart.Name = "lvSmart";
            this.lvSmart.UseCompatibleStateImageBehavior = false;
            this.lvSmart.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            resources.ApplyResources(this.chID, "chID");
            // 
            // chName
            // 
            resources.ApplyResources(this.chName, "chName");
            // 
            // chCurrent
            // 
            resources.ApplyResources(this.chCurrent, "chCurrent");
            // 
            // chWorst
            // 
            resources.ApplyResources(this.chWorst, "chWorst");
            // 
            // chThreshold
            // 
            resources.ApplyResources(this.chThreshold, "chThreshold");
            // 
            // chRawData
            // 
            resources.ApplyResources(this.chRawData, "chRawData");
            // 
            // chStatus
            // 
            resources.ApplyResources(this.chStatus, "chStatus");
            // 
            // SmartControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvSmart);
            this.Name = "SmartControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvSmart;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chCurrent;
        private System.Windows.Forms.ColumnHeader chWorst;
        private System.Windows.Forms.ColumnHeader chThreshold;
        private System.Windows.Forms.ColumnHeader chRawData;
        private System.Windows.Forms.ColumnHeader chStatus;
    }
}
