namespace WindowsFormsApp9
{
    partial class ResultsViewer
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
            this.hellodbDataSet = new WindowsFormsApp9.hellodbDataSet();
            this.hellodbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.hellodbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hellodbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hellodbDataSet
            // 
            this.hellodbDataSet.DataSetName = "hellodbDataSet";
            this.hellodbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hellodbDataSetBindingSource
            // 
            this.hellodbDataSetBindingSource.DataSource = this.hellodbDataSet;
            this.hellodbDataSetBindingSource.Position = 0;
            // 
            // ResultsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ResultsViewer";
            this.Text = "ResultsViewer";
            this.Load += new System.EventHandler(this.ResultsViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hellodbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hellodbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource hellodbDataSetBindingSource;
        private hellodbDataSet hellodbDataSet;
    }
}