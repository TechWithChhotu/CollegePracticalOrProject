Imports System.IO

Public Class Form1
    Private audioFiles As List(Of String)
    Private audioFiles2 As List(Of Object)

    Private currentTrackIndex As Integer = 0

    Dim paths As String()
    Dim fileNames As String()

    '*****************Main Load****************
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim folderPath As String = "C:\Users\chhot\Music"
        fileNames = Directory.GetFiles(folderPath, "*.*")
        ' Get all audio files in the folder
        audioFiles = Directory.GetFiles(folderPath, "*.*").ToList()

        ' Load the first track
        LoadTrack(currentTrackIndex)
        AxWindowsMediaPlayer1.Ctlcontrols.stop() 'Stop first audio

        For i As Integer = 0 To fileNames.Length - 1
            'ListBox1.Items.Add(fileNames(i)) 'This is add file path
            ListBox1.Items.Add(Path.GetFileName(fileNames(i)))
        Next
    End Sub

    '*****************Set Data in ListBox**************
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim index As Integer = ListBox1.SelectedIndex.ToString()
        Dim CurrentUrl As String = audioFiles(index)
        AxWindowsMediaPlayer1.URL = CurrentUrl

        'Get Thumbnail from URL
        Dim thumbnail As Image = GetSongThumbnail(CurrentUrl)

        'Set Thumbnail in panel
        Panel1.BackgroundImage = thumbnail
        Panel1.BackgroundImageLayout = ImageLayout.Stretch

        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub


    '**************GetSongThumbnail**************
    Private Function GetSongThumbnail(audioFilePath As String) As Image
        Dim tagFile As TagLib.File = TagLib.File.Create(audioFilePath)

        ' Check if the file has a picture (thumbnail)
        If tagFile.Tag.Pictures.Length > 0 Then
            Dim pictureData As Byte() = tagFile.Tag.Pictures(0).Data.Data
            Using memoryStream As New MemoryStream(pictureData)
                Return Image.FromStream(memoryStream)
            End Using
        Else
            Return GenerateRandomColorImage(200, 200)
        End If
    End Function




    '=================Generate a random color image===============
    Private Function GenerateRandomColorImage(width As Integer, height As Integer) As Image
        Dim random As New Random()
        Dim bitmap As New Bitmap(width, height)

        For x As Integer = 0 To width - 1
            For y As Integer = 0 To height - 1
                Dim color As Color = GenerateRandomColor(random)
                bitmap.SetPixel(x, y, color)
            Next
        Next

        Return bitmap
    End Function

    '=================Generate a random color================
    Private Function GenerateRandomColor(random As Random) As Color
        Dim red As Integer = random.Next(256)
        Dim green As Integer = random.Next(256)
        Dim blue As Integer = random.Next(256)

        Return Color.FromArgb(red, green, blue)
    End Function

    '=================Load Audio for ready to play=============
    Private Sub LoadTrack(index As Integer)
        If index >= 0 AndAlso index < audioFiles.Count Then
            ' Set the URL of the media player to the selected audio file
            AxWindowsMediaPlayer1.URL = audioFiles(index)

            ' Get the thumbnail from the audio file (you can customize this based on your needs)
            Dim thumbnail As Image = GetSongThumbnail(audioFiles(index))

            ' Set the thumbnail as the background of the PictureBox
            Panel1.BackgroundImage = thumbnail
            Panel1.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    '====================Next & Previous button====================
    ' Play the next track
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentTrackIndex = (currentTrackIndex + 1) Mod audioFiles.Count
        LoadTrack(currentTrackIndex)
    End Sub

    ' Play the previous track
    Private Sub btnPrevious_Click_1(sender As Object, e As EventArgs) Handles btnPrevious.Click
        currentTrackIndex = If(currentTrackIndex > 0, currentTrackIndex - 1, audioFiles.Count - 1)
        LoadTrack(currentTrackIndex)
    End Sub
End Class