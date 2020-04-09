Option Explicit On
Option Strict On
Option Compare Binary
Public Class RentalForm

    Public TotalCustomers As Integer
    Public TotalDistance As Decimal
    Public TotalCost As Decimal

    'Code that Loads when program starts
    Private Sub RentalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetAll()
        SummaryButton.Enabled = False
    End Sub

    'Clear Button Click
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ResetAll()
    End Sub

    'Calculate Button Click
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim tempNumber As Integer = 15

        'If Statement when true calculates the input data. If checks fail then the user is given a error message box
        If ValidateNameTextBox() = True And ValidateAddressTextBox() = True And ValidateCityTextBox() And ValidateStateTextBox() = True And ValidateZipCodeTextBox() = True And ValidateOdometer() = True And ValidateDaysTextBox() = True Then
            DistanceBox.Text = KilometersToMiles().ToString & " mi"
            MileageBox.Text = MileageCharge().ToString("C")
            DayBox.Text = DaysCharge().ToString("C")
            MinusBox.Text = Discount().ToString("C")
            YouOweBox.Text = TotalWithDiscount().ToString("C")
            UserMessages(False, "", True)
            TotalCustomers = Customers()
            TotalDistance = Distance()
            TotalCost = Cost()
        Else
            MsgBox(UserMessages(True, "", False))
            UserMessages(False, "", True)
        End If

        'Enables the Summary Button if data is input through the calculate button. 
        If TotalDistance > 0 And TotalCost > 0 Then
            SummaryButton.Enabled = True
        End If

    End Sub

    'Series of Validate Data functions used to analyze the input from the user
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

    'Function used to Construct a single user message with all error messages
    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean) As String
        Static formattedMessages As String

        If clearMessage = True Then
            formattedMessages = ""
        ElseIf addMessage = True Then
            formattedMessages &= message & vbNewLine
        End If

        Return formattedMessages
    End Function

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

        '2 discounts, AAA at 5% and Senior at 3%
        If AAAcheckbox.Checked = True Then
            totalDiscount = TotalWithoutDiscount() * AAARATE
        End If

        If Seniorcheckbox.Checked = True Then
            totalDiscount += TotalWithoutDiscount() * SENIORATE
        End If

        Return totalDiscount
    End Function

    'Function used to combine all cost into a total
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

    'Exit Button with warning message before closing
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Dim msg = "Are you sure you want to close the program?"
        'Uses MsgBox to display a warning before closing the program. 
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question
        Dim title = "Car Rental"
        Dim response = MsgBox(msg, style, title)

        If response = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click

        'Displays strings with the public variables that contain totals from each form
        MsgBox("Total Customers: " & TotalCustomers & vbNewLine & "Total Distance: " & TotalDistance & vbNewLine & "Total Charges: " & TotalCost.ToString("C"))

    End Sub

    Sub Summary(Customers As Integer, Distance As Decimal, Cost As Decimal)
        Static totalCustomers As Integer
        Static totalDistance As Decimal
        Static totalCost As Decimal

        totalCustomers += Customers
        totalDistance += Distance
        totalCost += Cost

    End Sub

    Function Customers() As Integer
        Static total As Integer

        total += 1

        Return total
    End Function

    Function Distance() As Decimal
        Dim stringLength As Integer = Len(DistanceBox.Text)
        Dim subtractedStringLength As String = LSet(DistanceBox.Text, stringLength - 3)
        Static total As Decimal

        total += CDec(subtractedStringLength)

        Return total
    End Function

    Function Cost() As Decimal
        Static total As Decimal

        total += CDec(YouOweBox.Text)

        Return total
    End Function

End Class
