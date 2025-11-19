Public Class Form1
    Dim road(7) As PictureBox     ' مصفوفة للصور
    Dim score As Integer = 0
    Dim speed As Integer = 3
    Public Sub gameover()   ' انشاء دالة انتهاء اللعبة 
        gameoverlbl.Visible = True  ' لاظهار اليبل تاع انتهاء اللعبة
        ' ايقاف جميع العدادات
        road_move.Stop()
        car1_move.Stop()
        car2_move.Stop()
        car3_move.Stop()
        Button1.Visible = True

    End Sub

    Private Sub road_move_Tick(sender As Object, e As EventArgs) Handles road_move.Tick

        If score > 20 And score < 30 Then
            speed = 4
        End If
        If score > 30 And score < 40 Then
            speed = 5
        End If
        If score > 40 And score < 50 Then
            speed = 6
        End If


        ' هنا عشان لما تصطدم السيارة باخرى تتنتهي اللعبة

        If mycar.Bounds.IntersectsWith(car1.Bounds) Then
            gameover()
        End If
        If mycar.Bounds.IntersectsWith(car2.Bounds) Then
            gameover()
        End If
        If mycar.Bounds.IntersectsWith(car3.Bounds) Then
            gameover()
        End If

        ' لجعل خطوط الشارع تتحرك على امتداد الشارع 
        For x As Integer = 0 To 7
            road(x).Top += speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' اعطاء قيم للمصفوفة من نوع صور 
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            move_right.Start()
        End If
        If e.KeyCode = Keys.Left Then
            move_left.Start()
        End If
    End Sub

    Private Sub move_left_Tick(sender As Object, e As EventArgs) Handles move_left.Tick
        ' لتحريك السيارة الخاصة فيك لليمين
        If mycar.Left > 0 Then
            mycar.Left -= 4
        End If


    End Sub

    Private Sub move_right_Tick(sender As Object, e As EventArgs) Handles move_right.Tick
        ' لتحريك السيارة الخاصة فيك لليسار
        If mycar.Left < 202 Then
            mycar.Left += 4
        End If


    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        move_right.Stop()
        move_left.Stop()
    End Sub

    Private Sub car1_move_Tick(sender As Object, e As EventArgs) Handles car1_move.Tick

        ' لجعل السيارات تغير اماكنهن بشكل عشوائي 
        If car1.Top >= Me.Height Then
            car1.Top = Int(Rnd() * 5)
            car1.Left = Int(Rnd() * 50)
            score += 1
            scorelbl.Text = score

            'car1.Top = -car1.Height
        End If

        car1.Top += speed
    End Sub

    Private Sub car2_move_Tick(sender As Object, e As EventArgs) Handles car2_move.Tick
        ' لجعل السيارات تغير اماكنهن بشكل عشوائي 
        If car2.Top >= Me.Height Then
            car2.Top = Int(Rnd() * 5)
            car2.Left = Int(Rnd() * 50) + 76
            score += 1
            scorelbl.Text = score

            'car2.Top = -car2.Height
        End If

        car2.Top += speed
    End Sub

    Private Sub car3_move_Tick(sender As Object, e As EventArgs) Handles car3_move.Tick
        ' لجعل السيارات تغير اماكنهن بشكل عشوائي
        If car3.Top >= Me.Height Then
            car3.Top = Int(Rnd() * 5)
            car3.Left = Int(Rnd() * 40) + 153
            score += 1
            scorelbl.Text = score

            'car3.Top = -car3.Height
        End If
        car3.Top += speed
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()  ' لاعادة تهئة الشاشة 
        Form1_Load(e, e)   ' لاعادة تحميل الشاشة جديدة
    End Sub
End Class
