﻿'Jamison Burton
'RCET0265
'Spring 2022
'Math Contest
'https://github.com/Reimonoe17/CarRental
Public Class CarRentalForm
    'Validate Requirements: begining odo must be smaller than ending odo,
    '   textboxs must be filled, number of days:0-45
    Sub ValidationTest()
        Dim days As Integer
        Dim endOdo As Integer = 1
        Dim beginOdo As Integer = 0
        Dim zip As Integer

        Try
            days = CInt(NumDayTextBox.Text)

            If days < 0 Then
                AccumulateMessage("Number of Days rented must be greater than 0")
                NumDayTextBox.Focus()
            End If

            If days > 45 Then
                AccumulateMessage("Number of Days rented can't be greater than 45")
                NumDayTextBox.Focus()
            End If

        Catch ex As Exception
            AccumulateMessage("Number of Days rented must be a number")
            NumDayTextBox.Focus()
        End Try

        Try
            endOdo = CInt(EndOdoTextBox.Text)
        Catch ex As Exception
            AccumulateMessage("Ending Odometer Reading must be a number")
            EndOdoTextBox.Focus()
        End Try

        Try
            beginOdo = CInt(BegOdoTextBox.Text)

            If beginOdo > endOdo Then
                AccumulateMessage("Ending Odometer Reading must be higher than Beginning Odometer Reading")
                BegOdoTextBox.Focus()
            End If

        Catch ex As Exception
            AccumulateMessage("Beginning Odometer Reading must be a number")
            BegOdoTextBox.Focus()
        End Try

        Try
            zip = CInt(ZipTextBox.Text)
        Catch ex As Exception
            AccumulateMessage("Zip Code must be a number")
            ZipTextBox.Focus()
        End Try

        If StateTextBox.Text = "" Then
            AccumulateMessage("Enter the customer's State")
            StateTextBox.Focus()
        End If

        If CityTextBox.Text = "" Then
            AccumulateMessage("Enter the customer's City")
            CityTextBox.Focus()
        End If

        If AddressTextBox.Text = "" Then
            AccumulateMessage("Enter the customer's Address")
            AddressTextBox.Focus()
        End If

        If CustomerNameTextBox.Text = "" Then
            AccumulateMessage("Enter the customer's Name")
            CustomerNameTextBox.Focus()
        End If

        If AccumulateMessage() <> "" Then
            MsgBox(AccumulateMessage())
            AccumulateMessage(, True)
        End If

    End Sub
    Private Function AccumulateMessage(Optional newMessage As String = "", Optional clear As Boolean = False) As String
        Static _message As String

        Select Case clear
            Case False
                If newMessage <> "" Then
                    _message &= newMessage & vbCrLf
                End If
            Case Else
                _message = ""
        End Select
        Return _message
    End Function

    Sub Calculation()
        Dim dailyCharge As Decimal = 15
        Dim mileCharge As Decimal
        Dim distance As Decimal
        Dim discount As Decimal

        DayChargeTextBox.Text = CDec(dailyCharge * NumDayTextBox.Text)

        If KilometerRadioButton.Checked Then
            distance = (CDec(EndOdoTextBox.Text) - CDec(BegOdoTextBox.Text)) * 0.62
        Else
            distance = CDec(EndOdoTextBox.Text) - CDec(BegOdoTextBox.Text)
        End If

        DrivenTextBox.Text = distance

        Select Case distance
            Case > 200
                mileCharge = 0
            Case < 201 And distance > 500
                mileCharge = 0.12
            Case < 500
                mileCharge = 0.1
        End Select

        MileChargeTextBox.Text = mileCharge * distance

        If AAACheckBox.Checked Then
            discount -= 0.05
        End If

        If SeniorCheckBox.Checked Then
            discount -= 0.03
        End If


    End Sub

    Private Sub TestButton_Click(sender As Object, e As EventArgs) Handles TestButton.Click
        CustomerNameTextBox.Text = "Harry Potter"
        AddressTextBox.Text = "4 Privet Drive"
        CityTextBox.Text = "Surry"
        StateTextBox.Text = "Wales"
        ZipTextBox.Text = 19314
        BegOdoTextBox.Text = 21800
        EndOdoTextBox.Text = 21915
        NumDayTextBox.Text = 20
    End Sub
End Class
