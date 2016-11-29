Public Class frmMain
    Dim SelectedOne As PictureBox : Dim TotalRow, TotalCol As Integer : Dim ArrayImages() As Integer : Dim GameTime As Integer
#Region "Least Important"
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Call tsbExit_Click(sender, e)
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call tsmiLevel1_Click(sender, e)
    End Sub
    Private Sub tsbNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbNew.Click
        Dim PictureBoxes() As PictureBox : Dim TotalPictures As Integer = 0 'level işaretini değiştiriyor
        tsmiLevel1.Checked = False : tsmiLevel2.Checked = False : tsmiLevel3.Checked = False : tsmiLevel4.Checked = False : tsmiLevel5.Checked = False
        Select Case sender.ToString
            Case "Level 2" : tsmiLevel2.Checked = True
            Case "Level 3" : tsmiLevel3.Checked = True
            Case "Level 4" : tsmiLevel4.Checked = True
            Case "Level 5" : tsmiLevel5.Checked = True
            Case Else : tsmiLevel1.Checked = True
        End Select
        For Each Pbox As Control In Me.Controls 'tüm picturebox kutularını bir diziye atıyor, ve sonra da siliyor
            If Pbox.Name = "GamePictureBtn" Then ReDim Preserve PictureBoxes(TotalPictures) : PictureBoxes(TotalPictures) = Pbox : TotalPictures = TotalPictures + 1
        Next '
        For i = 0 To TotalPictures - 1
            Me.Controls.Remove(PictureBoxes(i))
        Next i
        'yeni levela göre pictureboxları tekrar oluşturuyor
        Call CreateImages(TotalRow, TotalCol) : Timer1.Enabled = True : GameTime = 0 : Call Timer1_Tick(sender, e)
    End Sub
    Private Sub tsbOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbOpen.Click
        'kaydet şu andaki oyunu
    End Sub
    Private Sub tsbSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbSave.Click
        'kayıtlı bir oyunu aç
    End Sub
    Private Sub tsbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbExit.Click
        Me.Close() 'çıkış komutları
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim GameMin As String = Math.Floor(Convert.ToDouble(GameTime / 60)).ToString.PadLeft(2, "0")
        Dim GameSec As String = Math.Floor(Convert.ToDouble(GameTime Mod 60)).ToString.PadLeft(2, "0")
        tslStatus.Text = "Your time: " + GameMin + ":" + GameSec : GameTime += 1
    End Sub
    Private Sub tsmiLevel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiLevel1.Click
        TotalRow = 2 : TotalCol = 3 : Call tsbNew_Click(sender, e) 'rox*col çift olmak zorunda yoksa oyun bitmez
    End Sub
    Private Sub tsmiLevel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiLevel2.Click
        TotalRow = 2 : TotalCol = 4 : Call tsbNew_Click(sender, e) 'rox*col çift olmak zorunda yoksa oyun bitmez
    End Sub
    Private Sub tsmiLevel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiLevel3.Click
        TotalRow = 3 : TotalCol = 4 : Call tsbNew_Click(sender, e) 'rox*col çift olmak zorunda yoksa oyun bitmez
    End Sub
    Private Sub tsmiLevel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiLevel4.Click
        TotalRow = 3 : TotalCol = 6 : Call tsbNew_Click(sender, e) 'rox*col çift olmak zorunda yoksa oyun bitmez
    End Sub
    Private Sub tsmiLevel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiLevel5.Click
        TotalRow = 4 : TotalCol = 6 : Call tsbNew_Click(sender, e) 'rox*col çift olmak zorunda yoksa oyun bitmez
    End Sub
#End Region
#Region "Image Procedures"
    Private Sub CreateImages(ByVal RowCount As Integer, ByVal ColCount As Integer)
        Call CreateRndSeries(ColCount * RowCount)
        Dim GamePictureBtn As PictureBox : Dim tmp As Integer = 0
        For i = 0 To RowCount - 1
            For j = 0 To ColCount - 1 'istenilen sıra ve sütun sayısına göre picturebox oluşturuyor
                GamePictureBtn = New PictureBox : GamePictureBtn.Parent = Me : GamePictureBtn.Visible = True
                GamePictureBtn.Name = "GamePictureBtn" : GamePictureBtn.Tag = CStr(ArrayImages(tmp)) : tmp += 1
                GamePictureBtn.Size = New Size(90, 120) : GamePictureBtn.Top = 130 * i + 40 : GamePictureBtn.Left = 100 * j + 10
                GamePictureBtn.BackgroundImage = imageList1.Images(0) : GamePictureBtn.BackgroundImageLayout = ImageLayout.Stretch
                AddHandler GamePictureBtn.Click, AddressOf PictureBoxes_Click 'pictureboxların click eventi
            Next j
        Next i 'bundan sonra bir de dizi oluşturulacak. hangi resim hangi pictureboxta belli olsun diye
        Me.Width = ColCount * 100 + 30 : Me.Height = RowCount * 130 + 100 'formun büyüklüğü düzeltiliyor
    End Sub
    Private Sub CreateRndSeries(ByVal Max_Number As Integer)
        ReDim ArrayImages(Max_Number - 1) : Dim j As Integer = 0 : Dim tmp As Integer = Rnd() * (12 - (Max_Number / 2)) + 1
        For i = 0 To Max_Number - 1 'burada pictureboxlarda gösterilecek resimler bir diziye aktarılıyor
            ArrayImages(i) = j + tmp : If i Mod 2 = 1 Then j += 1
        Next 've hayret edilecek birşey: dizideki elemanların sırası rastgele bir şekilde değişiyor
        Shuffle(ArrayImages, 7) 'arrayimages disini 7 kere karıştır
    End Sub
    Private Sub Shuffle(ByRef arrayToBeShuffled As Array, ByVal numberOfTimesToShuffle As Integer)
        Dim rndPosition As New Random(DateTime.Now.Millisecond)
        For i As Integer = 1 To numberOfTimesToShuffle
            For i2 As Integer = 1 To arrayToBeShuffled.Length
                swap(arrayToBeShuffled(rndPosition.Next(0, arrayToBeShuffled.Length)), arrayToBeShuffled(rndPosition.Next(0, arrayToBeShuffled.Length)))
            Next i2
        Next i
    End Sub
    Private Sub swap(ByRef arg1 As Object, ByRef arg2 As Object) 'belirtilen iki değişkenin değerleri yer değiştiriliyor
        Dim strTemp As String : strTemp = arg1 : arg1 = arg2 : arg2 = strTemp
    End Sub
    Private Sub PictureBoxes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If SelectedOne Is Nothing Then 'eğer ilk defa tıklanıyorsa
            SelectedOne = sender : OpenImages(SelectedOne, CInt(SelectedOne.Tag)) 'tıklanan pictureboxu bir değişkene atar
        Else 'ikince defaya tıklanıyorsa onu da başka bir değişkene at ve karşılaştırmalar yapar
            Dim tmpName As PictureBox = sender
            If tmpName.Equals(SelectedOne) Then Exit Sub
            OpenImages(tmpName, CInt(tmpName.Tag)) : Me.Refresh() : System.Threading.Thread.Sleep(300)
            If tmpName.Tag = SelectedOne.Tag Then
                tmpName.Visible = False : SelectedOne.Visible = False 'eğer iki açılan resim de aynıysa ikisini de görünmeaz yapar
                Call CheckEndofGame()
            Else
                OpenImages(tmpName, 0, SelectedOne, False)
                'tmpName.BackgroundImage = imageList1.Images(0) : SelectedOne.BackgroundImage = imageList1.Images(0) 'eğer iki açılan resim aynıo değilse ikisini de kapat
            End If
            SelectedOne = Nothing
        End If
    End Sub
    Private Sub CheckEndofGame() 'eğer tüm pictureboxların visible=false ise oyunu bitir
        For Each Pbox As Control In Me.Controls
            If Pbox.Name = "GamePictureBtn" Then If Pbox.Visible = True Then Exit Sub
        Next
        Timer1.Enabled = False : tslStatus.Text = "Game over" : MsgBox("Bravo! You have finished the game." & vbNewLine & tslStatus.Text)
    End Sub
    Private Sub OpenImages(ByVal varPicture As PictureBox, ByVal varImage As Integer, Optional ByVal varPicture2 As PictureBox = Nothing, Optional ByVal isEmpty As Boolean = True)
        Dim tmpWidth As Integer = varPicture.Width : Dim tmpLeft As Integer = varPicture.Left
        For i = tmpWidth To 0 Step -10 'resmi açarken boyutunu küçültüp büyütüyor:atraksiyon
            If isEmpty = False Then varPicture2.Width -= 6 : varPicture2.Left += 3
            varPicture.Width -= 6 : varPicture.Left += 3 : Me.Refresh()
        Next
        varPicture.BackgroundImage = imageList1.Images(varImage) : If isEmpty = False Then varPicture2.BackgroundImage = imageList1.Images(varImage)
        For i = 0 To tmpWidth Step 10
            If isEmpty = False Then varPicture2.Width += 6 : varPicture2.Left -= 3
            varPicture.Width += 6 : varPicture.Left -= 3 : Me.Refresh()
        Next
    End Sub
#End Region
End Class
