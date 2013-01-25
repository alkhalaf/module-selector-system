
Partial Class ProgressBar
    Inherits System.Web.UI.UserControl

    Private _colFillColor As Drawing.Color
    Private _colBackcolor As Drawing.Color
    Private _colBorderColor As Drawing.Color = Drawing.Color.Black

    Private _intBorder As Integer = 1
    Private _intCellspacing As Integer = 1
    Private _intCellpadding As Integer = 1
    Private _intHeight As Integer = 15
    Private _intWidth As Integer = 100

    Private _intBlockNumber As Integer = 5
    Private _intValue As Integer
    Private _tblBlock As TableRow

    Public Property BGColor() As Drawing.Color
        Get
            Return _colBackcolor
        End Get
        Set(ByVal value As Drawing.Color)
            _colBackcolor = value
        End Set
    End Property
    Public Property FillColor() As Drawing.Color
        Get
            Return _colFillColor
        End Get
        Set(ByVal value As Drawing.Color)
            _colFillColor = value
        End Set
    End Property
    Public Property BorderColor() As Drawing.Color
        Get
            Return _colBorderColor
        End Get
        Set(ByVal value As Drawing.Color)
            _colBorderColor = value
        End Set
    End Property
    Public Property BorderSize() As Integer
        Get
            Return _intBorder
        End Get
        Set(ByVal value As Integer)
            _intBorder = value
        End Set
    End Property
    Public Property Cellpadding() As Integer
        Get
            Return _intCellpadding
        End Get
        Set(ByVal value As Integer)
            _intCellpadding = value
        End Set
    End Property
    Public Property CellSpacing() As Integer
        Get
            Return _intCellspacing
        End Get
        Set(ByVal value As Integer)
            _intCellspacing = value
        End Set
    End Property
    Public Property Blocks() As Integer
        Get
            Return _intBlockNumber
        End Get
        Set(ByVal value As Integer)
            _intBlockNumber = value
        End Set
    End Property

    Public Property Value() As Integer
        Get
            Return _intValue
        End Get
        Set(ByVal value As Integer)
            _intValue = value
        End Set
    End Property
    Public Property Height() As Integer
        Get
            Return _intHeight
        End Get
        Set(ByVal value As Integer)
            _intHeight = value
        End Set
    End Property
    Public Property Width() As Integer
        Get
            Return _intWidth
        End Get
        Set(ByVal value As Integer)
            _intWidth = value
        End Set
    End Property
    Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreRender
        Dim intBlocks As Integer

        ' add a new row to the table
        _tblBlock = New TableRow()
        ' create cells and add to the row
        For intBlocks = 1 To Me.Blocks
            Dim tblCell As New TableCell
            tblCell.Text = " "
            If intBlocks <= Math.Ceiling((Me.Value * Me.Blocks / 100)) Then
                tblCell.BackColor = Me.FillColor
            End If
            _tblBlock.Cells.Add(tblCell)
        Next
        tblProgressBar.Rows.Add(_tblBlock)

        'set the progress bar properties
        tblProgressBar.CellPadding = Me.Cellpadding
        tblProgressBar.CellSpacing = Me.CellSpacing
        tblProgressBar.Width = Me.Width
        tblProgressBar.Height = Me.Height
        tblProgressBar.BackColor = Me.BGColor
        tblProgressBar.BorderColor = Me.BorderColor

    End Sub
End Class
