Option Explicit On
Option Strict On
Option Compare Binary
Public Class RentalForm

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim tempNumber As Integer = 15

        If ValidateNameTextBox() = True And ValidateAddressTextBox() = True And ValidateCityTextBox() And ValidateStateTextBox() = True And ValidateZipCodeTextBox() = True And ValidateOdometer() = True And ValidateDaysTextBox() = True Then
            DistanceBox.Text = KilometersToMiles().ToString & " mi"
            MileageBox.Text = MileageCharge().ToString("C")
            DayBox.Text = DaysCharge().ToString("C")
            MinusBox.Text = Discount().ToString("C")
            YouOweBox.Text = TotalWithDiscount().ToString("C")
            UserMessages(False, "", True)

            Summary()
        Else
            MsgBox(UserMessages(True, "", False))
            UserMessages(False, "", True)
        End If

    End Sub




    Sub Summary()
        Static totalCustomers As Integer = 0
        Static totalDistance As Decimal = 0
        Static totalCharges As Decimal = 0

        'need to add number of customers and display the summary mesg box

        totalDistance += CDec(DistanceBox.Text)
        totalCharges += CDec(YouOweBox.Text)

        If totalDistance > 0 And totalCharges > 0 Then
            SummaryButton.Enabled = True
        End If

    End Sub







    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ResetAll()
    End Sub

    Function ValidateOdometer() As Boolean
        Dim userMessage As String
        Dim trueOrFalse As Boolean = True

        Try
            If CDec(BeginOdometerTextBox.Text) > CDec(EndOdometerTextBox.Text) Then
                userMessage = "Beginning Odometer Must be Smaller than Ending Odometer."
                BeginOdometerTextBox.Text = ""
                EndOdometerTextBox.Text = ""
                trueOrFalse = False
            End If
        Catch ex As Exception
            userMessage = "Odometer entries must be numbers."
            BeginOdometerTextBox.Text = ""
            EndOdometerTextBox.Text = ""
            trueOrFalse = False
        End Try

        UserMessages(True, userMessage, False)
        Return trueOrFalse
    End Function

    Function ValidateNameTextBox() As Boolean
        Dim userMessage As String
        Dim trueOrFalse As Boolean = True

        If NameTextBox.Text = "" Then
            userMessage = "Please enter a Name."
            UserMessages(True, userMessage, False)
            NameTextBox.Focus()
            trueOrFalse = False
        End If

        Return trueOrFalse
    End Function

    Function ValidateAddressTextBox() As Boolean
        Dim userMessage As String
        Dim trueOrFalse As Boolean = True

        If AddressTextBox.Text = "" Then
            userMessage = "Please enter an Address."
            UserMessages(True, userMessage, False)
            NameTextBox.Focus()
            trueOrFalse = False
        End If

        Return trueOrFalse
    End Function

    Function ValidateCityTextBox() As Boolean
        Dim userMessage As String
        Dim trueOrFalse As Boolean = True

        If CityTextBox.Text = "" Then
            userMessage = "Please enter a City."
            UserMessages(True, userMessage, False)
            NameTextBox.Focus()
            trueOrFalse = False
        End If

        Return trueOrFalse
    End Function

    Function ValidateStateTextBox() As Boolean
        Dim userMessage As String
        Dim trueOrFalse As Boolean = True

        If StateTextBox.Text = "" Then
            userMessage = "Please enter a State."
            UserMessages(True, userMessage, False)
            NameTextBox.Focus()
            trueOrFalse = False
        End If

        Return trueOrFalse
    End Function

    Function ValidateZipCodeTextBox() As Boolean
        Dim userMessage As String
        Dim zipCode As Integer
        Dim trueOrFalse As Boolean = True

        Try
            zipCode = CInt(ZipCodeTextBox.Text)
        Catch ex As Exception
            userMessage = "Please enter a valid Zip Code."
            UserMessages(True, userMessage, False)
            ZipCodeTextBox.Text = ""
            ZipCodeTextBox.Focus()
            trueOrFalse = False
        End Try

        Return trueOrFalse
    End Function

    Function ValidateDaysTextBox() As Boolean
        Dim userMessage As String
        Dim trueOrFalse As Boolean = True

        Try
            If CInt(DaysTextBox.Text) > 45 Or CInt(DaysTextBox.Text) < 1 Then
                userMessage = "Please enter days between 1 and 45."
                UserMessages(True, userMessage, False)
                DaysTextBox.Text = ""
                trueOrFalse = False
            End If

        Catch ex As Exception
            userMessage = "Days must be numeric."
            UserMessages(True, userMessage, False)
            DaysTextBox.Text = ""
            DaysTextBox.Focus()
            trueOrFalse = False
        End Try

        Return trueOrFalse
    End Function

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

        Try
            miles = CDec(EndOdometerTextBox.Text) - CDec(BeginOdometerTextBox.Text)
        Catch
        End Try

        If KilometersradioButton.Checked = True Then
            Try
                miles *= CDec(0.62)
            Catch
            End Try
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
        Select Case miles
            Case < 201
                milesCharge = miles * FREERATE
            Case > 500
                milesCharge = 300 * REGULARRATE
                milesCharge += (miles - 500) * LOWRATE
            Case Else
                milesCharge = (miles - 200) * REGULARRATE
        End Select

        Return milesCharge

    End Function

    Function DaysCharge() As Integer
        Const DAYPRICE As Integer = 15

        Try
            DaysCharge = CInt(DaysTextBox.Text) * DAYPRICE
        Catch
        End Try


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
        DistanceBox.Text = ""
        MileageBox.Text = ""
        DayBox.Text = ""
        MinusBox.Text = ""
        YouOweBox.Text = ""

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click

        'How do you bring up a box with yes or no when the exit button is clicked?
        'How do you make the summary button? How do you add the totals into an array? How do you use an array in VB in forms?

        Me.Close()
    End Sub

    Private Sub RentalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ResetAll()
        SummaryButton.Enabled = False


    End Sub


End Class
