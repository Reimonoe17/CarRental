<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarRentalForm
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
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.NumDayTextBox = New System.Windows.Forms.TextBox()
        Me.EndOdoTextBox = New System.Windows.Forms.TextBox()
        Me.BegOdoTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.YouOweTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.DayChargeTextBox = New System.Windows.Forms.TextBox()
        Me.MileChargeTextBox = New System.Windows.Forms.TextBox()
        Me.DrivenTextBox = New System.Windows.Forms.TextBox()
        Me.MilesOrKilometerGroupBox = New System.Windows.Forms.GroupBox()
        Me.KilometerRadioButton = New System.Windows.Forms.RadioButton()
        Me.MilesRadioButton = New System.Windows.Forms.RadioButton()
        Me.DiscountGroupBox = New System.Windows.Forms.GroupBox()
        Me.SeniorCheckBox = New System.Windows.Forms.CheckBox()
        Me.AAACheckBox = New System.Windows.Forms.CheckBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SummayButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CustomerNameLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.ZipCodeLabel = New System.Windows.Forms.Label()
        Me.BeginngOdometerReadindLabel = New System.Windows.Forms.Label()
        Me.EndingOdometerReadingLabel = New System.Windows.Forms.Label()
        Me.NumberofDaysLabel = New System.Windows.Forms.Label()
        Me.YouOweLabel = New System.Windows.Forms.Label()
        Me.MinusDiscountLabel = New System.Windows.Forms.Label()
        Me.DayChargeLabel = New System.Windows.Forms.Label()
        Me.MileageChargeLabel = New System.Windows.Forms.Label()
        Me.DistanceDrivenInMilesLabel = New System.Windows.Forms.Label()
        Me.TestButton = New System.Windows.Forms.Button()
        Me.MilesOrKilometerGroupBox.SuspendLayout()
        Me.DiscountGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(235, 12)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(160, 26)
        Me.CustomerNameTextBox.TabIndex = 0
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(235, 44)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(160, 26)
        Me.AddressTextBox.TabIndex = 1
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(235, 76)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(160, 26)
        Me.CityTextBox.TabIndex = 2
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(235, 108)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(160, 26)
        Me.StateTextBox.TabIndex = 3
        '
        'NumDayTextBox
        '
        Me.NumDayTextBox.Location = New System.Drawing.Point(235, 236)
        Me.NumDayTextBox.Name = "NumDayTextBox"
        Me.NumDayTextBox.Size = New System.Drawing.Size(160, 26)
        Me.NumDayTextBox.TabIndex = 7
        '
        'EndOdoTextBox
        '
        Me.EndOdoTextBox.Location = New System.Drawing.Point(235, 204)
        Me.EndOdoTextBox.Name = "EndOdoTextBox"
        Me.EndOdoTextBox.Size = New System.Drawing.Size(160, 26)
        Me.EndOdoTextBox.TabIndex = 6
        '
        'BegOdoTextBox
        '
        Me.BegOdoTextBox.Location = New System.Drawing.Point(235, 172)
        Me.BegOdoTextBox.Name = "BegOdoTextBox"
        Me.BegOdoTextBox.Size = New System.Drawing.Size(160, 26)
        Me.BegOdoTextBox.TabIndex = 5
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(235, 140)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(160, 26)
        Me.ZipTextBox.TabIndex = 4
        '
        'YouOweTextBox
        '
        Me.YouOweTextBox.Location = New System.Drawing.Point(623, 140)
        Me.YouOweTextBox.Name = "YouOweTextBox"
        Me.YouOweTextBox.Size = New System.Drawing.Size(132, 26)
        Me.YouOweTextBox.TabIndex = 12
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.Location = New System.Drawing.Point(623, 108)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.Size = New System.Drawing.Size(132, 26)
        Me.DiscountTextBox.TabIndex = 11
        '
        'DayChargeTextBox
        '
        Me.DayChargeTextBox.Location = New System.Drawing.Point(623, 76)
        Me.DayChargeTextBox.Name = "DayChargeTextBox"
        Me.DayChargeTextBox.Size = New System.Drawing.Size(132, 26)
        Me.DayChargeTextBox.TabIndex = 10
        '
        'MileChargeTextBox
        '
        Me.MileChargeTextBox.Location = New System.Drawing.Point(623, 44)
        Me.MileChargeTextBox.Name = "MileChargeTextBox"
        Me.MileChargeTextBox.Size = New System.Drawing.Size(132, 26)
        Me.MileChargeTextBox.TabIndex = 9
        '
        'DrivenTextBox
        '
        Me.DrivenTextBox.Location = New System.Drawing.Point(623, 12)
        Me.DrivenTextBox.Name = "DrivenTextBox"
        Me.DrivenTextBox.Size = New System.Drawing.Size(132, 26)
        Me.DrivenTextBox.TabIndex = 8
        '
        'MilesOrKilometerGroupBox
        '
        Me.MilesOrKilometerGroupBox.Controls.Add(Me.KilometerRadioButton)
        Me.MilesOrKilometerGroupBox.Controls.Add(Me.MilesRadioButton)
        Me.MilesOrKilometerGroupBox.Location = New System.Drawing.Point(12, 286)
        Me.MilesOrKilometerGroupBox.Name = "MilesOrKilometerGroupBox"
        Me.MilesOrKilometerGroupBox.Size = New System.Drawing.Size(372, 91)
        Me.MilesOrKilometerGroupBox.TabIndex = 13
        Me.MilesOrKilometerGroupBox.TabStop = False
        Me.MilesOrKilometerGroupBox.Text = "Is the Odometer in Miles or Kilometers"
        '
        'KilometerRadioButton
        '
        Me.KilometerRadioButton.AutoSize = True
        Me.KilometerRadioButton.Location = New System.Drawing.Point(22, 55)
        Me.KilometerRadioButton.Name = "KilometerRadioButton"
        Me.KilometerRadioButton.Size = New System.Drawing.Size(108, 24)
        Me.KilometerRadioButton.TabIndex = 1
        Me.KilometerRadioButton.TabStop = True
        Me.KilometerRadioButton.Text = "Kilometers"
        Me.KilometerRadioButton.UseVisualStyleBackColor = True
        '
        'MilesRadioButton
        '
        Me.MilesRadioButton.AutoSize = True
        Me.MilesRadioButton.Checked = True
        Me.MilesRadioButton.Location = New System.Drawing.Point(22, 25)
        Me.MilesRadioButton.Name = "MilesRadioButton"
        Me.MilesRadioButton.Size = New System.Drawing.Size(70, 24)
        Me.MilesRadioButton.TabIndex = 0
        Me.MilesRadioButton.TabStop = True
        Me.MilesRadioButton.Text = "Miles"
        Me.MilesRadioButton.UseVisualStyleBackColor = True
        '
        'DiscountGroupBox
        '
        Me.DiscountGroupBox.Controls.Add(Me.SeniorCheckBox)
        Me.DiscountGroupBox.Controls.Add(Me.AAACheckBox)
        Me.DiscountGroupBox.Location = New System.Drawing.Point(390, 286)
        Me.DiscountGroupBox.Name = "DiscountGroupBox"
        Me.DiscountGroupBox.Size = New System.Drawing.Size(398, 91)
        Me.DiscountGroupBox.TabIndex = 14
        Me.DiscountGroupBox.TabStop = False
        Me.DiscountGroupBox.Text = "Enter any Discounts"
        '
        'SeniorCheckBox
        '
        Me.SeniorCheckBox.AutoSize = True
        Me.SeniorCheckBox.Location = New System.Drawing.Point(36, 55)
        Me.SeniorCheckBox.Name = "SeniorCheckBox"
        Me.SeniorCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.SeniorCheckBox.TabIndex = 33
        Me.SeniorCheckBox.Text = "Senior Citizen Discount"
        Me.SeniorCheckBox.UseVisualStyleBackColor = True
        '
        'AAACheckBox
        '
        Me.AAACheckBox.AutoSize = True
        Me.AAACheckBox.Location = New System.Drawing.Point(36, 26)
        Me.AAACheckBox.Name = "AAACheckBox"
        Me.AAACheckBox.Size = New System.Drawing.Size(197, 24)
        Me.AAACheckBox.TabIndex = 32
        Me.AAACheckBox.Text = "AAA Member Discount"
        Me.AAACheckBox.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(122, 396)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(128, 42)
        Me.CalculateButton.TabIndex = 15
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(256, 396)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(128, 42)
        Me.ClearButton.TabIndex = 16
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SummayButton
        '
        Me.SummayButton.Enabled = False
        Me.SummayButton.Location = New System.Drawing.Point(390, 396)
        Me.SummayButton.Name = "SummayButton"
        Me.SummayButton.Size = New System.Drawing.Size(128, 42)
        Me.SummayButton.TabIndex = 18
        Me.SummayButton.Text = "Summary"
        Me.SummayButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(524, 396)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(128, 42)
        Me.ExitButton.TabIndex = 17
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CustomerNameLabel
        '
        Me.CustomerNameLabel.AutoSize = True
        Me.CustomerNameLabel.Location = New System.Drawing.Point(12, 15)
        Me.CustomerNameLabel.Name = "CustomerNameLabel"
        Me.CustomerNameLabel.Size = New System.Drawing.Size(124, 20)
        Me.CustomerNameLabel.TabIndex = 19
        Me.CustomerNameLabel.Text = "Customer Name"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(12, 47)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(68, 20)
        Me.AddressLabel.TabIndex = 20
        Me.AddressLabel.Text = "Address"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(12, 79)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(35, 20)
        Me.CityLabel.TabIndex = 21
        Me.CityLabel.Text = "City"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(12, 111)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(48, 20)
        Me.StateLabel.TabIndex = 22
        Me.StateLabel.Text = "State"
        '
        'ZipCodeLabel
        '
        Me.ZipCodeLabel.AutoSize = True
        Me.ZipCodeLabel.Location = New System.Drawing.Point(12, 143)
        Me.ZipCodeLabel.Name = "ZipCodeLabel"
        Me.ZipCodeLabel.Size = New System.Drawing.Size(73, 20)
        Me.ZipCodeLabel.TabIndex = 26
        Me.ZipCodeLabel.Text = "Zip Code"
        '
        'BeginngOdometerReadindLabel
        '
        Me.BeginngOdometerReadindLabel.AutoSize = True
        Me.BeginngOdometerReadindLabel.Location = New System.Drawing.Point(12, 175)
        Me.BeginngOdometerReadindLabel.Name = "BeginngOdometerReadindLabel"
        Me.BeginngOdometerReadindLabel.Size = New System.Drawing.Size(219, 20)
        Me.BeginngOdometerReadindLabel.TabIndex = 25
        Me.BeginngOdometerReadindLabel.Text = "Beginning Odometer Reading"
        '
        'EndingOdometerReadingLabel
        '
        Me.EndingOdometerReadingLabel.AutoSize = True
        Me.EndingOdometerReadingLabel.Location = New System.Drawing.Point(12, 207)
        Me.EndingOdometerReadingLabel.Name = "EndingOdometerReadingLabel"
        Me.EndingOdometerReadingLabel.Size = New System.Drawing.Size(198, 20)
        Me.EndingOdometerReadingLabel.TabIndex = 24
        Me.EndingOdometerReadingLabel.Text = "Ending Odometer Reading"
        '
        'NumberofDaysLabel
        '
        Me.NumberofDaysLabel.AutoSize = True
        Me.NumberofDaysLabel.Location = New System.Drawing.Point(12, 239)
        Me.NumberofDaysLabel.Name = "NumberofDaysLabel"
        Me.NumberofDaysLabel.Size = New System.Drawing.Size(123, 20)
        Me.NumberofDaysLabel.TabIndex = 23
        Me.NumberofDaysLabel.Text = "Number of Days"
        '
        'YouOweLabel
        '
        Me.YouOweLabel.AutoSize = True
        Me.YouOweLabel.Location = New System.Drawing.Point(436, 143)
        Me.YouOweLabel.Name = "YouOweLabel"
        Me.YouOweLabel.Size = New System.Drawing.Size(74, 20)
        Me.YouOweLabel.TabIndex = 31
        Me.YouOweLabel.Text = "You Owe"
        '
        'MinusDiscountLabel
        '
        Me.MinusDiscountLabel.AutoSize = True
        Me.MinusDiscountLabel.Location = New System.Drawing.Point(436, 111)
        Me.MinusDiscountLabel.Name = "MinusDiscountLabel"
        Me.MinusDiscountLabel.Size = New System.Drawing.Size(118, 20)
        Me.MinusDiscountLabel.TabIndex = 30
        Me.MinusDiscountLabel.Text = "Minus Discount"
        '
        'DayChargeLabel
        '
        Me.DayChargeLabel.AutoSize = True
        Me.DayChargeLabel.Location = New System.Drawing.Point(436, 79)
        Me.DayChargeLabel.Name = "DayChargeLabel"
        Me.DayChargeLabel.Size = New System.Drawing.Size(93, 20)
        Me.DayChargeLabel.TabIndex = 29
        Me.DayChargeLabel.Text = "Day Charge"
        '
        'MileageChargeLabel
        '
        Me.MileageChargeLabel.AutoSize = True
        Me.MileageChargeLabel.Location = New System.Drawing.Point(436, 47)
        Me.MileageChargeLabel.Name = "MileageChargeLabel"
        Me.MileageChargeLabel.Size = New System.Drawing.Size(120, 20)
        Me.MileageChargeLabel.TabIndex = 28
        Me.MileageChargeLabel.Text = "Mileage Charge"
        '
        'DistanceDrivenInMilesLabel
        '
        Me.DistanceDrivenInMilesLabel.AutoSize = True
        Me.DistanceDrivenInMilesLabel.Location = New System.Drawing.Point(436, 15)
        Me.DistanceDrivenInMilesLabel.Name = "DistanceDrivenInMilesLabel"
        Me.DistanceDrivenInMilesLabel.Size = New System.Drawing.Size(177, 20)
        Me.DistanceDrivenInMilesLabel.TabIndex = 27
        Me.DistanceDrivenInMilesLabel.Text = "Distance Driven in Miles"
        '
        'TestButton
        '
        Me.TestButton.Location = New System.Drawing.Point(524, 207)
        Me.TestButton.Name = "TestButton"
        Me.TestButton.Size = New System.Drawing.Size(94, 44)
        Me.TestButton.TabIndex = 32
        Me.TestButton.Text = "Test"
        Me.TestButton.UseVisualStyleBackColor = True
        '
        'CarRentalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TestButton)
        Me.Controls.Add(Me.YouOweLabel)
        Me.Controls.Add(Me.MinusDiscountLabel)
        Me.Controls.Add(Me.DayChargeLabel)
        Me.Controls.Add(Me.MileageChargeLabel)
        Me.Controls.Add(Me.DistanceDrivenInMilesLabel)
        Me.Controls.Add(Me.ZipCodeLabel)
        Me.Controls.Add(Me.BeginngOdometerReadindLabel)
        Me.Controls.Add(Me.EndingOdometerReadingLabel)
        Me.Controls.Add(Me.NumberofDaysLabel)
        Me.Controls.Add(Me.StateLabel)
        Me.Controls.Add(Me.CityLabel)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.CustomerNameLabel)
        Me.Controls.Add(Me.SummayButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.DiscountGroupBox)
        Me.Controls.Add(Me.MilesOrKilometerGroupBox)
        Me.Controls.Add(Me.YouOweTextBox)
        Me.Controls.Add(Me.DiscountTextBox)
        Me.Controls.Add(Me.DayChargeTextBox)
        Me.Controls.Add(Me.MileChargeTextBox)
        Me.Controls.Add(Me.DrivenTextBox)
        Me.Controls.Add(Me.NumDayTextBox)
        Me.Controls.Add(Me.EndOdoTextBox)
        Me.Controls.Add(Me.BegOdoTextBox)
        Me.Controls.Add(Me.ZipTextBox)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Name = "CarRentalForm"
        Me.Text = "Acme Care Rental Service"
        Me.MilesOrKilometerGroupBox.ResumeLayout(False)
        Me.MilesOrKilometerGroupBox.PerformLayout()
        Me.DiscountGroupBox.ResumeLayout(False)
        Me.DiscountGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents NumDayTextBox As TextBox
    Friend WithEvents EndOdoTextBox As TextBox
    Friend WithEvents BegOdoTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents YouOweTextBox As TextBox
    Friend WithEvents DiscountTextBox As TextBox
    Friend WithEvents DayChargeTextBox As TextBox
    Friend WithEvents MileChargeTextBox As TextBox
    Friend WithEvents DrivenTextBox As TextBox
    Friend WithEvents MilesOrKilometerGroupBox As GroupBox
    Friend WithEvents DiscountGroupBox As GroupBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummayButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents CustomerNameLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents CityLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents ZipCodeLabel As Label
    Friend WithEvents BeginngOdometerReadindLabel As Label
    Friend WithEvents EndingOdometerReadingLabel As Label
    Friend WithEvents NumberofDaysLabel As Label
    Friend WithEvents YouOweLabel As Label
    Friend WithEvents MinusDiscountLabel As Label
    Friend WithEvents DayChargeLabel As Label
    Friend WithEvents MileageChargeLabel As Label
    Friend WithEvents DistanceDrivenInMilesLabel As Label
    Friend WithEvents KilometerRadioButton As RadioButton
    Friend WithEvents MilesRadioButton As RadioButton
    Friend WithEvents SeniorCheckBox As CheckBox
    Friend WithEvents AAACheckBox As CheckBox
    Friend WithEvents TestButton As Button
End Class
