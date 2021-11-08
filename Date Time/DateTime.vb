Public Class DateTime
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("dd-MMM-yyyy  hh:mm:ss")
    End Sub

    Private Sub exitt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitt.Click
        Close()
    End Sub
    Private Sub exitt_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitt.MouseEnter
        exitt.BackColor = Color.Red
    End Sub

    Private Sub exitt_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitt.MouseLeave
        exitt.BackColor = Color.Transparent
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        themepanel.Visible = False
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Private Sub Form1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter
        Me.Opacity = 1
    End Sub

    Private Sub Form1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseLeave
        Me.Opacity = 0.75
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        themepanel.Visible = False
        timepanel.Visible = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        themepanel.Visible = True
        timepanel.Visible = False
    End Sub

    Private Sub themepanel_MouseEnter(sender As Object, e As EventArgs) Handles themepanel.MouseEnter
        Opacity = 1
    End Sub

    Private Sub savetheme_Click(sender As Object, e As EventArgs) Handles savetheme.Click
        If Me.theme1.Checked Then
            Me.BackColor = Color.FromArgb(140, 141, 141)
            Me.themepanel.BackColor = Color.FromArgb(222, 239, 90)
            Me.timepanel.BackColor = Color.FromArgb(222, 239, 90)
            Me.Label1.BackColor = Color.FromArgb(140, 141, 141)
            Me.toolbar.BackColor = Color.FromArgb(222, 239, 90)
        ElseIf Me.theme2.Checked Then
            Me.BackColor = Color.FromArgb(73, 188, 217)
            Me.themepanel.BackColor = Color.FromArgb(247, 135, 74)
            Me.timepanel.BackColor = Color.FromArgb(247, 135, 74)
            Me.Label1.BackColor = Color.FromArgb(73, 188, 217)
            Me.toolbar.BackColor = Color.FromArgb(247, 135, 74)
        ElseIf Me.theme3.Checked Then
            Me.BackColor = Color.FromArgb(241, 243, 252)
            Me.themepanel.BackColor = Color.FromArgb(92, 93, 92)
            Me.timepanel.BackColor = Color.FromArgb(92, 93, 92)
            Me.Label1.BackColor = Color.FromArgb(73, 74, 74)
            Me.toolbar.BackColor = Color.FromArgb(73, 74, 74)
        ElseIf Me.theme4.Checked Then
            Me.BackColor = Color.FromArgb(139, 125, 171)
            Me.themepanel.BackColor = Color.FromArgb(233, 181, 172)
            Me.timepanel.BackColor = Color.FromArgb(233, 181, 172)
            Me.Label1.BackColor = Color.FromArgb(139, 125, 171)
            Me.toolbar.BackColor = Color.FromArgb(233, 181, 172)
        ElseIf Me.defaullt.Checked Then
            Me.Controls.Clear() 'removes all the controls on the form
            InitializeComponent() 'load all the controls again
            Form1_Load(e, e) 'Load everything in your form, load event again
        End If
    End Sub

    Private Sub themepanel_Paint(sender As Object, e As PaintEventArgs) Handles themepanel.Paint

    End Sub
End Class
