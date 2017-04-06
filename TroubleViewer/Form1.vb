Imports System.Drawing
Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        '画像の一部を切り取って（トリミングして）表示する

        '描画先とするImageオブジェクトを作成する
        Dim canvas As New Bitmap(PictureBox1.Width, PictureBox1.Height)
        'ImageオブジェクトのGraphicsオブジェクトを作成する
        Dim g As Graphics = Graphics.FromImage(canvas)

        '画像ファイルのImageオブジェクトを作成する
        Dim img As New Bitmap("c:\test\tokuten2.png")

        '切り取る部分の範囲を決定する。ここでは、位置(10,10)、大きさ100x100
        Dim srcRect As New Rectangle(100, 100, 100, 100)
        '描画する部分の範囲を決定する。ここでは、位置(0,0)、大きさ100x100で描画する
        Dim desRect As New Rectangle(0, 0, srcRect.Width, srcRect.Height)
        '画像の一部を描画する
        g.DrawImage(img, desRect, srcRect, GraphicsUnit.Pixel)

        'Graphicsオブジェクトのリソースを解放する
        g.Dispose()

        'PictureBox1に表示する
        PictureBox1.Image = canvas
    End Sub

End Class
