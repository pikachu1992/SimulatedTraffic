namespace SimulatedTraffic
{
    partial class Form1
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
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnGetXpndrAsync = new System.Windows.Forms.Button();
            this.btnCreateAITraffic = new System.Windows.Forms.Button();
            this.btnSetAiFlightPlan = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSendAITrafficInstruction = new System.Windows.Forms.Button();
            this.btnRequestAIState = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(12, 12);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(360, 510);
            this.txtLog.TabIndex = 1;
            this.txtLog.Text = "";
            // 
            // btnGetXpndrAsync
            // 
            this.btnGetXpndrAsync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetXpndrAsync.Location = new System.Drawing.Point(12, 528);
            this.btnGetXpndrAsync.Name = "btnGetXpndrAsync";
            this.btnGetXpndrAsync.Size = new System.Drawing.Size(98, 23);
            this.btnGetXpndrAsync.TabIndex = 2;
            this.btnGetXpndrAsync.Text = "GetXpndrAsnc";
            this.btnGetXpndrAsync.UseVisualStyleBackColor = true;
            this.btnGetXpndrAsync.Click += new System.EventHandler(this.btnGeXpndrAsync_Click);
            // 
            // btnCreateAITraffic
            // 
            this.btnCreateAITraffic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateAITraffic.Location = new System.Drawing.Point(116, 528);
            this.btnCreateAITraffic.Name = "btnCreateAITraffic";
            this.btnCreateAITraffic.Size = new System.Drawing.Size(98, 23);
            this.btnCreateAITraffic.TabIndex = 3;
            this.btnCreateAITraffic.Text = "CreateAITraffic";
            this.btnCreateAITraffic.UseVisualStyleBackColor = true;
            this.btnCreateAITraffic.Click += new System.EventHandler(this.btnCreateAITraffic_Click);
            // 
            // btnSetAiFlightPlan
            // 
            this.btnSetAiFlightPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetAiFlightPlan.Location = new System.Drawing.Point(220, 528);
            this.btnSetAiFlightPlan.Name = "btnSetAiFlightPlan";
            this.btnSetAiFlightPlan.Size = new System.Drawing.Size(98, 23);
            this.btnSetAiFlightPlan.TabIndex = 4;
            this.btnSetAiFlightPlan.Text = "SetAiFlightPlan";
            this.btnSetAiFlightPlan.UseVisualStyleBackColor = true;
            this.btnSetAiFlightPlan.Click += new System.EventHandler(this.btnSetAiFlightPlan_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 590);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSendAITrafficInstruction
            // 
            this.btnSendAITrafficInstruction.Location = new System.Drawing.Point(93, 590);
            this.btnSendAITrafficInstruction.Name = "btnSendAITrafficInstruction";
            this.btnSendAITrafficInstruction.Size = new System.Drawing.Size(75, 23);
            this.btnSendAITrafficInstruction.TabIndex = 6;
            this.btnSendAITrafficInstruction.Text = "SendInstruction";
            this.btnSendAITrafficInstruction.UseVisualStyleBackColor = true;
            this.btnSendAITrafficInstruction.Click += new System.EventHandler(this.btnSendAITrafficInstruction_Click);
            // 
            // btnRequestAIState
            // 
            this.btnRequestAIState.Location = new System.Drawing.Point(174, 590);
            this.btnRequestAIState.Name = "btnRequestAIState";
            this.btnRequestAIState.Size = new System.Drawing.Size(75, 23);
            this.btnRequestAIState.TabIndex = 7;
            this.btnRequestAIState.Text = "RequestAIState";
            this.btnRequestAIState.UseVisualStyleBackColor = true;
            this.btnRequestAIState.Click += new System.EventHandler(this.btnRequestAIState_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 625);
            this.Controls.Add(this.btnRequestAIState);
            this.Controls.Add(this.btnSendAITrafficInstruction);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnSetAiFlightPlan);
            this.Controls.Add(this.btnCreateAITraffic);
            this.Controls.Add(this.btnGetXpndrAsync);
            this.Controls.Add(this.txtLog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnGetXpndrAsync;
        private System.Windows.Forms.Button btnCreateAITraffic;
        private System.Windows.Forms.Button btnSetAiFlightPlan;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSendAITrafficInstruction;
        private System.Windows.Forms.Button btnRequestAIState;
    }
}

