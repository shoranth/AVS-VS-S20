Option Explicit On
Option Strict On
Option Compare Binary
Public Class RentalForm


    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim tempNumber As Integer = 15

        'If allChecksAreValid() Then
            ''procede to calcs and updates
        'Else
            ''alert user
        'End If

        ValidateNameTextBox()
        ValidateAddressTextBox()
        ValidateCityTextBox()
        ValidateStateTextBox()
        ValidateZipCodeTextBox()
        ValidateOdometer()
        ValidateDaysTextBox()
        MsgBox(UserMessages(True, "", False))
        DistanceBox.Text = KilometersToMiles().ToString
        MileageBox.Text = MileageCharge().ToString("C")
        DayBox.Text = DaysCharge().ToString("C")
        MinusBox.Text = Discount().ToString("C")
        YouOweBox.Text = TotalWithDiscount().ToString("C")


    End Sub


    Sub ValidateOdometer()
        Dim userMessage As String

        Try
            If CDec(BeginOdometerTextBox.Text) > CDec(EndOdometerTextBox.Text) Then
                userMessage = "Beginning Odometer Must be Smaller than Ending Odometer."
                BeginOdometerTextBox.Text = ""
                EndOdometerTextBox.Text = ""
            End If
        Catch ex As Exception
            userMessage = "Odometer entries must be numbers."
            BeginOdometerTextBox.Text = ""
            EndOdometerTextBox.Text = ""
        End Try

        UserMessages(True, userMessage, False)
    End Sub

    Sub ValidateNameTextBox()
        Dim userMessage As String

        If NameTextBox.Text = "" Then
            userMessage = "Please enter a Name."
            UserMessages(True, userMessage, False)
            NameTextBox.Focus()
        End If

    End Sub

    Sub ValidateAddressTextBox()
        Dim userMessage As String

        If AddressTextBox.Text = "" Then
            userMessage = "Please enter an Address."
            UserMessages(True, userMessage, False)
            NameTextBox.Focus()
        End If

    End Sub

    Sub ValidateCityTextBox()
        Dim userMessage As String

        If CityTextBox.Text = "" Then
            userMessage = "Please enter a City."
            UserMessages(True, userMessage, False)
            NameTextBox.Focus()
        End If

    End Sub

    Sub ValidateStateTextBox()
        Dim userMessage As String

        If StateTextBox.Text = "" Then
            userMessage = "Please enter a State."
            UserMessages(True, userMessage, False)
            NameTextBox.Focus()
        End If

    End Sub

    Sub ValidateZipCodeTextBox()
        Dim userMessage As String
        Dim zipCode As Integer

        Try
            zipCode = CInt(ZipCodeTextBox.Text)
        Catch ex As Exception
            userMessage = "Please enter a valid Zip Code."
            UserMessages(True, userMessage, False)
            ZipCodeTextBox.Text = ""
            ZipCodeTextBox.Focus()
        End Try

    End Sub

    Sub ValidateDaysTextBox()
        Dim userMessage As String

        Try
            If CInt(DaysTextBox.Text) > 45 And CInt(DaysTextBox.Text) < 1 Then
                userMessage = "Please enter days between 1 and 45."
                DaysTextBox.Text = ""
            End If

        Catch ex As Exception
            userMessage = "Days must be numeric."
            UserMessages(True, userMessage, False)
            DaysTextBox.Text = ""
            DaysTextBox.Focus()
        End Try

    End Sub

    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean) As String
        Static formattedMessages As String

        If clearMessage = True Then
            formattedMessages = ""
        ElseIf addMessage = True Then
            formattedMessages &= message & vbNewLine
        End If

        Return formattedMessages
    End Function

    'Function ValidateAll() As Boolean
        'Dim result As Boolean
        ''Performs all validation checks and returns as true if all checks pass
        'Return result
   ' End Function

    Function KilometersToMiles() As Decimal
        Dim miles As Decimal

        miles = CDec(EndOdometerTextBox.Text) - CDec(BeginOdometerTextBox.Text)

        If KilometersradioButton.Checked = True Then
            miles *= CDec(0.62)
        End If

        Return miles
    End Function

    Function MileageCharge() As Decimal
        Dim milesCharge As Decimal
        Dim miles As Decimal = KilometersToMiles()
        Const REGULARRATE = 0.12D
        Const LOWRATE = 0.1D
        Const FREERATE = 0D

        'Mileage Charge
        'First 200 miles driven are always free. 
        'All miles between 201 And 500 inclusive are .12 cents per mile. 
        'miles greater than 500 are charged at .10 cents per mile.

        'The way this case is written is that if the miles go to 201 they are charged for 201 miles and not 1 miles. Is that how it is supposed to be?
        Select Case miles
            Case < 201
                milesCharge = miles * FREERATE
            Case > 500
                milesCharge = miles * LOWRATE
            Case Else
                milesCharge = miles * REGULARRATE
        End Select

        Return milesCharge
    End Function

    Function DaysCharge() As Integer
        Const DAYPRICE As Integer = 15

        DaysCharge = CInt(DaysTextBox.Text) * DAYPRICE

        Return DaysCharge
    End Function

    Function TotalWithoutDiscount() As Decimal

        TotalWithoutDiscount = MileageCharge() + DaysCharge()

        Return TotalWithoutDiscount
    End Function

    Function Discount() As Decimal
        Dim totalDiscount As Decimal
        Const AAARATE = 0.05D
        Const SENIORATE = 0.03D

        If AAAcheckbox.Checked = True Then
            totalDiscount = TotalWithoutDiscount() * AAARATE
        End If

        If Seniorcheckbox.Checked = True Then
            totalDiscount += TotalWithoutDiscount() * SENIORATE
        End If

        Return totalDiscount
    End Function

    Function TotalWithDiscount() As Decimal

        TotalWithDiscount = MileageCharge() + DaysCharge() - Discount()

        Return TotalWithDiscount
    End Function

    Sub ResetAll()
        'Clear Everything on the Form

        NameTextBox.Text = ""
        AddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipCodeTextBox.Text = ""
        BeginOdometerTextBox.Text = ""
        EndOdometerTextBox.Text = ""
        DaysTextBox.Text = ""
        MilesradioButton.Checked = True
        AAAcheckbox.Checked = False
        Seniorcheckbox.Checked = False

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub RentalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ResetAll()
        SummaryButton.Enabled = False


    End Sub

End Class
