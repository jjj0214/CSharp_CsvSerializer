namespace TestCsv
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSaveCSV = new System.Windows.Forms.Button();
			this.btnLoadCSV = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSaveCSV
			// 
			this.btnSaveCSV.Location = new System.Drawing.Point(43, 38);
			this.btnSaveCSV.Name = "btnSaveCSV";
			this.btnSaveCSV.Size = new System.Drawing.Size(75, 23);
			this.btnSaveCSV.TabIndex = 0;
			this.btnSaveCSV.Text = "Save";
			this.btnSaveCSV.UseVisualStyleBackColor = true;
			this.btnSaveCSV.Click += new System.EventHandler(this.btnSaveCSV_Click);
			// 
			// btnLoadCSV
			// 
			this.btnLoadCSV.Location = new System.Drawing.Point(144, 38);
			this.btnLoadCSV.Name = "btnLoadCSV";
			this.btnLoadCSV.Size = new System.Drawing.Size(75, 23);
			this.btnLoadCSV.TabIndex = 0;
			this.btnLoadCSV.Text = "Load";
			this.btnLoadCSV.UseVisualStyleBackColor = true;
			this.btnLoadCSV.Click += new System.EventHandler(this.btnLoadCSV_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(257, 104);
			this.Controls.Add(this.btnLoadCSV);
			this.Controls.Add(this.btnSaveCSV);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSaveCSV;
		private System.Windows.Forms.Button btnLoadCSV;
	}
}

