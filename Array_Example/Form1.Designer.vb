<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvListOfStudents = New System.Windows.Forms.DataGridView()
        Me.StudentName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentMarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.btnAddStudentAndMarks = New System.Windows.Forms.Button()
        Me.btnBest = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        CType(Me.dgvListOfStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List of Students"
        '
        'dgvListOfStudents
        '
        Me.dgvListOfStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListOfStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentName, Me.StudentMarks})
        Me.dgvListOfStudents.Location = New System.Drawing.Point(15, 40)
        Me.dgvListOfStudents.Name = "dgvListOfStudents"
        Me.dgvListOfStudents.ReadOnly = True
        Me.dgvListOfStudents.Size = New System.Drawing.Size(247, 197)
        Me.dgvListOfStudents.TabIndex = 1
        '
        'StudentName
        '
        Me.StudentName.HeaderText = "Student Name"
        Me.StudentName.Name = "StudentName"
        Me.StudentName.ReadOnly = True
        '
        'StudentMarks
        '
        Me.StudentMarks.HeaderText = "Student Marks"
        Me.StudentMarks.Name = "StudentMarks"
        Me.StudentMarks.ReadOnly = True
        '
        'btnAverage
        '
        Me.btnAverage.Location = New System.Drawing.Point(93, 372)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(110, 29)
        Me.btnAverage.TabIndex = 2
        Me.btnAverage.Text = "Average"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'btnAddStudentAndMarks
        '
        Me.btnAddStudentAndMarks.Location = New System.Drawing.Point(15, 265)
        Me.btnAddStudentAndMarks.Name = "btnAddStudentAndMarks"
        Me.btnAddStudentAndMarks.Size = New System.Drawing.Size(247, 44)
        Me.btnAddStudentAndMarks.TabIndex = 3
        Me.btnAddStudentAndMarks.Text = "Add Students and Marks"
        Me.btnAddStudentAndMarks.UseVisualStyleBackColor = True
        '
        'btnBest
        '
        Me.btnBest.Location = New System.Drawing.Point(16, 329)
        Me.btnBest.Name = "btnBest"
        Me.btnBest.Size = New System.Drawing.Size(123, 24)
        Me.btnBest.TabIndex = 4
        Me.btnBest.Text = "Who is the BEST?"
        Me.btnBest.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(144, 329)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(120, 24)
        Me.btnLast.TabIndex = 5
        Me.btnLast.Text = "Who is the LAST?"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 425)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnBest)
        Me.Controls.Add(Me.btnAddStudentAndMarks)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.dgvListOfStudents)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Array Example"
        CType(Me.dgvListOfStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvListOfStudents As DataGridView
    Friend WithEvents StudentName As DataGridViewTextBoxColumn
    Friend WithEvents StudentMarks As DataGridViewTextBoxColumn
    Friend WithEvents btnAverage As Button
    Friend WithEvents btnAddStudentAndMarks As Button
    Friend WithEvents btnBest As Button
    Friend WithEvents btnLast As Button
End Class
