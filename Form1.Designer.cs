using System.Drawing;
using System.Windows.Forms;

namespace Quiz
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBoxAdvisor;
        private System.Windows.Forms.GroupBox groupBoxStudent;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Label lblAdvisorName;
        private System.Windows.Forms.TextBox txtAdvisorName;
        private System.Windows.Forms.Label lblAdvisorDepartment;
        private System.Windows.Forms.TextBox txtAdvisorDepartment;
        private System.Windows.Forms.Button btnAddAdvisor;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentDepartment;
        private System.Windows.Forms.TextBox txtStudentDepartment;
        private System.Windows.Forms.Label lblStudentGrade;
        private System.Windows.Forms.TextBox txtStudentGrade;
        private System.Windows.Forms.Label lblStudentAdvisor;
        private System.Windows.Forms.TextBox txtStudentAdvisor;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label lblSearchAdvisor;
        private System.Windows.Forms.TextBox txtAdvisorSearch;
        private System.Windows.Forms.Button btnShowAdvisorStudents;
        private System.Windows.Forms.Button btnTopStudent;
        private System.Windows.Forms.DataGridView dataGridViewStudents;

        private void InitializeComponent()
        {
            this.groupBoxAdvisor = new System.Windows.Forms.GroupBox();
            this.lblAdvisorName = new System.Windows.Forms.Label();
            this.txtAdvisorName = new System.Windows.Forms.TextBox();
            this.lblAdvisorDepartment = new System.Windows.Forms.Label();
            this.txtAdvisorDepartment = new System.Windows.Forms.TextBox();
            this.btnAddAdvisor = new System.Windows.Forms.Button();
            this.groupBoxStudent = new System.Windows.Forms.GroupBox();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentDepartment = new System.Windows.Forms.Label();
            this.txtStudentDepartment = new System.Windows.Forms.TextBox();
            this.lblStudentGrade = new System.Windows.Forms.Label();
            this.txtStudentGrade = new System.Windows.Forms.TextBox();
            this.lblStudentAdvisor = new System.Windows.Forms.Label();
            this.txtStudentAdvisor = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.lblSearchAdvisor = new System.Windows.Forms.Label();
            this.txtAdvisorSearch = new System.Windows.Forms.TextBox();
            this.btnShowAdvisorStudents = new System.Windows.Forms.Button();
            this.btnTopStudent = new System.Windows.Forms.Button();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.groupBoxAdvisor.SuspendLayout();
            this.groupBoxStudent.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAdvisor
            // 
            this.groupBoxAdvisor.Controls.Add(this.lblAdvisorName);
            this.groupBoxAdvisor.Controls.Add(this.txtAdvisorName);
            this.groupBoxAdvisor.Controls.Add(this.lblAdvisorDepartment);
            this.groupBoxAdvisor.Controls.Add(this.txtAdvisorDepartment);
            this.groupBoxAdvisor.Controls.Add(this.btnAddAdvisor);
            this.groupBoxAdvisor.Location = new System.Drawing.Point(20, 20);
            this.groupBoxAdvisor.Name = "groupBoxAdvisor";
            this.groupBoxAdvisor.Size = new System.Drawing.Size(350, 150);
            this.groupBoxAdvisor.TabIndex = 0;
            this.groupBoxAdvisor.TabStop = false;
            this.groupBoxAdvisor.Text = "เพิ่มอาจารย์ที่ปรึกษา";
            // 
            // lblAdvisorName
            // 
            this.lblAdvisorName.Location = new System.Drawing.Point(10, 20);
            this.lblAdvisorName.Name = "lblAdvisorName";
            this.lblAdvisorName.Size = new System.Drawing.Size(100, 23);
            this.lblAdvisorName.TabIndex = 0;
            this.lblAdvisorName.Text = "ชื่ออาจารย์";
            // 
            // txtAdvisorName
            // 
            this.txtAdvisorName.Location = new System.Drawing.Point(120, 20);
            this.txtAdvisorName.Name = "txtAdvisorName";
            this.txtAdvisorName.Size = new System.Drawing.Size(200, 20);
            this.txtAdvisorName.TabIndex = 1;
            // 
            // lblAdvisorDepartment
            // 
            this.lblAdvisorDepartment.Location = new System.Drawing.Point(10, 50);
            this.lblAdvisorDepartment.Name = "lblAdvisorDepartment";
            this.lblAdvisorDepartment.Size = new System.Drawing.Size(100, 23);
            this.lblAdvisorDepartment.TabIndex = 2;
            this.lblAdvisorDepartment.Text = "สาขา";
            // 
            // txtAdvisorDepartment
            // 
            this.txtAdvisorDepartment.Location = new System.Drawing.Point(120, 50);
            this.txtAdvisorDepartment.Name = "txtAdvisorDepartment";
            this.txtAdvisorDepartment.Size = new System.Drawing.Size(200, 20);
            this.txtAdvisorDepartment.TabIndex = 3;
            // 
            // btnAddAdvisor
            // 
            this.btnAddAdvisor.Location = new System.Drawing.Point(120, 80);
            this.btnAddAdvisor.Name = "btnAddAdvisor";
            this.btnAddAdvisor.Size = new System.Drawing.Size(75, 23);
            this.btnAddAdvisor.TabIndex = 4;
            this.btnAddAdvisor.Text = "เพิ่มอาจารย์";
            // 
            // groupBoxStudent
            // 
            this.groupBoxStudent.Controls.Add(this.lblStudentID);
            this.groupBoxStudent.Controls.Add(this.txtStudentID);
            this.groupBoxStudent.Controls.Add(this.lblStudentName);
            this.groupBoxStudent.Controls.Add(this.txtStudentName);
            this.groupBoxStudent.Controls.Add(this.lblStudentDepartment);
            this.groupBoxStudent.Controls.Add(this.txtStudentDepartment);
            this.groupBoxStudent.Controls.Add(this.lblStudentGrade);
            this.groupBoxStudent.Controls.Add(this.txtStudentGrade);
            this.groupBoxStudent.Controls.Add(this.lblStudentAdvisor);
            this.groupBoxStudent.Controls.Add(this.txtStudentAdvisor);
            this.groupBoxStudent.Controls.Add(this.btnAddStudent);
            this.groupBoxStudent.Location = new System.Drawing.Point(422, 20);
            this.groupBoxStudent.Name = "groupBoxStudent";
            this.groupBoxStudent.Size = new System.Drawing.Size(350, 250);
            this.groupBoxStudent.TabIndex = 1;
            this.groupBoxStudent.TabStop = false;
            this.groupBoxStudent.Text = "เพิ่มนักศึกษา";
            // 
            // lblStudentID
            // 
            this.lblStudentID.Location = new System.Drawing.Point(10, 20);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(100, 23);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "รหัสนักศึกษา";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(120, 20);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(200, 20);
            this.txtStudentID.TabIndex = 1;
            // 
            // lblStudentName
            // 
            this.lblStudentName.Location = new System.Drawing.Point(10, 50);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(100, 23);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "ชื่อนักศึกษา";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(120, 50);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(200, 20);
            this.txtStudentName.TabIndex = 3;
            // 
            // lblStudentDepartment
            // 
            this.lblStudentDepartment.Location = new System.Drawing.Point(10, 80);
            this.lblStudentDepartment.Name = "lblStudentDepartment";
            this.lblStudentDepartment.Size = new System.Drawing.Size(100, 23);
            this.lblStudentDepartment.TabIndex = 4;
            this.lblStudentDepartment.Text = "สาขา";
            // 
            // txtStudentDepartment
            // 
            this.txtStudentDepartment.Location = new System.Drawing.Point(120, 80);
            this.txtStudentDepartment.Name = "txtStudentDepartment";
            this.txtStudentDepartment.Size = new System.Drawing.Size(200, 20);
            this.txtStudentDepartment.TabIndex = 5;
            // 
            // lblStudentGrade
            // 
            this.lblStudentGrade.Location = new System.Drawing.Point(10, 110);
            this.lblStudentGrade.Name = "lblStudentGrade";
            this.lblStudentGrade.Size = new System.Drawing.Size(100, 23);
            this.lblStudentGrade.TabIndex = 6;
            this.lblStudentGrade.Text = "เกรด";
            // 
            // txtStudentGrade
            // 
            this.txtStudentGrade.Location = new System.Drawing.Point(120, 110);
            this.txtStudentGrade.Name = "txtStudentGrade";
            this.txtStudentGrade.Size = new System.Drawing.Size(200, 20);
            this.txtStudentGrade.TabIndex = 7;
            // 
            // lblStudentAdvisor
            // 
            this.lblStudentAdvisor.Location = new System.Drawing.Point(10, 140);
            this.lblStudentAdvisor.Name = "lblStudentAdvisor";
            this.lblStudentAdvisor.Size = new System.Drawing.Size(100, 23);
            this.lblStudentAdvisor.TabIndex = 8;
            this.lblStudentAdvisor.Text = "อาจารย์ที่ปรึกษา";
            // 
            // txtStudentAdvisor
            // 
            this.txtStudentAdvisor.Location = new System.Drawing.Point(120, 140);
            this.txtStudentAdvisor.Name = "txtStudentAdvisor";
            this.txtStudentAdvisor.Size = new System.Drawing.Size(200, 20);
            this.txtStudentAdvisor.TabIndex = 9;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(120, 170);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(97, 23);
            this.btnAddStudent.TabIndex = 10;
            this.btnAddStudent.Text = "เพิ่มนักศึกษา";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.lblSearchAdvisor);
            this.groupBoxSearch.Controls.Add(this.txtAdvisorSearch);
            this.groupBoxSearch.Controls.Add(this.btnShowAdvisorStudents);
            this.groupBoxSearch.Controls.Add(this.btnTopStudent);
            this.groupBoxSearch.Location = new System.Drawing.Point(20, 206);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(350, 120);
            this.groupBoxSearch.TabIndex = 2;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "ค้นหานักศึกษา";
            // 
            // lblSearchAdvisor
            // 
            this.lblSearchAdvisor.Location = new System.Drawing.Point(10, 20);
            this.lblSearchAdvisor.Name = "lblSearchAdvisor";
            this.lblSearchAdvisor.Size = new System.Drawing.Size(100, 23);
            this.lblSearchAdvisor.TabIndex = 0;
            this.lblSearchAdvisor.Text = "ชื่ออาจารย์";
            // 
            // txtAdvisorSearch
            // 
            this.txtAdvisorSearch.Location = new System.Drawing.Point(120, 20);
            this.txtAdvisorSearch.Name = "txtAdvisorSearch";
            this.txtAdvisorSearch.Size = new System.Drawing.Size(200, 20);
            this.txtAdvisorSearch.TabIndex = 1;
            // 
            // btnShowAdvisorStudents
            // 
            this.btnShowAdvisorStudents.Location = new System.Drawing.Point(120, 50);
            this.btnShowAdvisorStudents.Name = "btnShowAdvisorStudents";
            this.btnShowAdvisorStudents.Size = new System.Drawing.Size(107, 23);
            this.btnShowAdvisorStudents.TabIndex = 2;
            this.btnShowAdvisorStudents.Text = "แสดงนักศึกษา";
            // 
            // btnTopStudent
            // 
            this.btnTopStudent.Location = new System.Drawing.Point(120, 80);
            this.btnTopStudent.Name = "btnTopStudent";
            this.btnTopStudent.Size = new System.Drawing.Size(107, 23);
            this.btnTopStudent.TabIndex = 3;
            this.btnTopStudent.Text = "นักศึกษาที่ดีที่สุด";
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 332);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(372, 200);
            this.dataGridViewStudents.TabIndex = 3;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBoxAdvisor);
            this.Controls.Add(this.groupBoxStudent);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.dataGridViewStudents);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ระบบบันทึกข้อมูลนักศึกษาและที่ปรึกษา";
            this.groupBoxAdvisor.ResumeLayout(false);
            this.groupBoxAdvisor.PerformLayout();
            this.groupBoxStudent.ResumeLayout(false);
            this.groupBoxStudent.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);

        }
    }
}