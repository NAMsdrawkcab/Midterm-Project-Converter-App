<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.picBuilding = New System.Windows.Forms.PictureBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConversion = New System.Windows.Forms.Label()
        Me.grpMeasure = New System.Windows.Forms.GroupBox()
        Me.radMeterToInch = New System.Windows.Forms.RadioButton()
        Me.radInchToMeter = New System.Windows.Forms.RadioButton()
        Me.txtValue = New System.Windows.Forms.TextBox()
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMeasure.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBuilding
        '
        Me.picBuilding.Image = CType(resources.GetObject("picBuilding.Image"), System.Drawing.Image)
        Me.picBuilding.Location = New System.Drawing.Point(-1, 12)
        Me.picBuilding.Name = "picBuilding"
        Me.picBuilding.Size = New System.Drawing.Size(269, 191)
        Me.picBuilding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBuilding.TabIndex = 0
        Me.picBuilding.TabStop = False
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Stencil", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnConvert.Location = New System.Drawing.Point(39, 377)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(194, 47)
        Me.btnConvert.TabIndex = 1
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Stencil", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(303, 377)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(194, 47)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Stencil", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(567, 377)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(194, 47)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHeading.Location = New System.Drawing.Point(318, 34)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(247, 33)
        Me.lblHeading.TabIndex = 4
        Me.lblHeading.Text = "Converter App"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblInstructions.Location = New System.Drawing.Point(302, 89)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(178, 44)
        Me.lblInstructions.TabIndex = 5
        Me.lblInstructions.Text = "Enter a value and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "choose conversion"
        '
        'lblConversion
        '
        Me.lblConversion.AutoSize = True
        Me.lblConversion.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblConversion.Location = New System.Drawing.Point(378, 316)
        Me.lblConversion.Name = "lblConversion"
        Me.lblConversion.Size = New System.Drawing.Size(251, 24)
        Me.lblConversion.TabIndex = 6
        Me.lblConversion.Text = "X measure is Y measure"
        '
        'grpMeasure
        '
        Me.grpMeasure.BackColor = System.Drawing.Color.DarkKhaki
        Me.grpMeasure.Controls.Add(Me.radMeterToInch)
        Me.grpMeasure.Controls.Add(Me.radInchToMeter)
        Me.grpMeasure.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpMeasure.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.grpMeasure.Location = New System.Drawing.Point(372, 168)
        Me.grpMeasure.Name = "grpMeasure"
        Me.grpMeasure.Size = New System.Drawing.Size(286, 110)
        Me.grpMeasure.TabIndex = 7
        Me.grpMeasure.TabStop = False
        Me.grpMeasure.Text = "Convert Measurement"
        '
        'radMeterToInch
        '
        Me.radMeterToInch.AutoSize = True
        Me.radMeterToInch.Location = New System.Drawing.Point(6, 71)
        Me.radMeterToInch.Name = "radMeterToInch"
        Me.radMeterToInch.Size = New System.Drawing.Size(184, 26)
        Me.radMeterToInch.TabIndex = 1
        Me.radMeterToInch.TabStop = True
        Me.radMeterToInch.Text = "Meters to Inches"
        Me.radMeterToInch.UseVisualStyleBackColor = True
        '
        'radInchToMeter
        '
        Me.radInchToMeter.AutoSize = True
        Me.radInchToMeter.Location = New System.Drawing.Point(6, 28)
        Me.radInchToMeter.Name = "radInchToMeter"
        Me.radInchToMeter.Size = New System.Drawing.Size(184, 26)
        Me.radInchToMeter.TabIndex = 0
        Me.radInchToMeter.TabStop = True
        Me.radInchToMeter.Text = "Inches to Meters"
        Me.radInchToMeter.UseVisualStyleBackColor = True
        '
        'txtValue
        '
        Me.txtValue.BackColor = System.Drawing.Color.DarkKhaki
        Me.txtValue.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtValue.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtValue.Location = New System.Drawing.Point(591, 98)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(125, 29)
        Me.txtValue.TabIndex = 8
        Me.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AcceptButton = Me.btnConvert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.grpMeasure)
        Me.Controls.Add(Me.lblConversion)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.picBuilding)
        Me.Name = "Form1"
        Me.Text = "Building Plans Conversion"
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMeasure.ResumeLayout(False)
        Me.grpMeasure.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBuilding As PictureBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblConversion As Label
    Friend WithEvents grpMeasure As GroupBox
    Friend WithEvents radMeterToInch As RadioButton
    Friend WithEvents radInchToMeter As RadioButton
    Friend WithEvents txtValue As TextBox
End Class
