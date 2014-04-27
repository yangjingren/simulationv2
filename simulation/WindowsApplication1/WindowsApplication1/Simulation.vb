﻿Imports System.Windows.Forms.DataVisualization.Charting


Public Class Simulation

    Private Sub Simulation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Size(660, 400)
        Me.MaximumSize = New Size(660, 400)
        Me.MinimumSize = New Size(660, 400)
        Chart1.Series.Clear()
        Chart1.Titles.Add("Simulation")
        Dim s As New Series
        s.ChartType = SeriesChartType.Line
        With Chart1.ChartAreas(0)
            .AxisX.Minimum = 0
            .AxisX.Maximum = 100
            .AxisY.Minimum = 0
            .AxisY.Maximum = 100
            .AxisY.Interval = 10
            .AxisX.Interval = 10
            .AxisX.Title = "Simulation #"
            .AxisY.Title = "Expected Visitors"
        End With
        s.Points.AddXY(0, 0)
        s.Points.AddXY(1, 0)
        Chart1.Series.Add(s)
        Chart1.Visible = True
        femaleTbar.Minimum = ("0")
        femaleTbar.Maximum = ("100")
        femaleTbar.TickFrequency = ("10")
        maleTbar.Minimum = ("0")
        maleTbar.Maximum = ("100")
        maleTbar.TickFrequency = ("10")
        maleTbar.Value = ("50")
        femaleTbar.Value = ("50")
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles locationLbl.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textRdbtn.CheckedChanged

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles populationLbl.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mypopRdbtn.CheckedChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton2_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Chart1.Series.Clear()
        Dim s As New Series
        s.chartType = SeriesChartType.Line
        s.Points.AddXY(10, 27)
        s.Points.AddXY(20, 15)
        s.Points.AddXY(30, 17)
        Chart1.Series.Add(s)
        Chart1.Visible = True
    End Sub

    Private Sub MaskedTextBox3_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles popTxt.MaskInputRejected

    End Sub

    Private Sub zipTxt_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles zipTxt.MaskInputRejected

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub genderBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles genderBox.Enter

    End Sub

    

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton2_CheckedChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles femaleLbl.Click

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub TrackBar2_Scroll_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles childrenTbar.Scroll

    End Sub

    Private Sub TrackBar3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles youngTbar.Scroll

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teensTbar.Scroll

    End Sub

    Private Sub TrackBar4_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adultTbar.Scroll

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TrackBar5_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles elderlyTbar.Scroll

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub advoptLbl_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles advoptLbl.LinkClicked
        If Me.MaximumSize.Height = 400 Then
            Me.MaximumSize = New Size(660, 750)
            Me.Size = New Size(660, 750)
            Me.AutoScroll = True
        Else
            Me.MaximumSize = New Size(660, 400)
            Me.Size = New Size(660, 400)
            Me.AutoScroll = False
        End If
    End Sub

    Private Sub maleTbar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maleTbar.Scroll
        
    End Sub

    Private Sub malePerLbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles malePerLbl.Click

    End Sub
    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles femaleTbar.Scroll
        
    End Sub
    Private Sub maleTbar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maleTbar.ValueChanged
        malePerLbl.Text = maleTbar.Value
        femaleTbar.Value = 100 - maleTbar.Value
    End Sub
    
    Private Sub femaleTbar_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles femaleTbar.ValueChanged
        femalePerLbl.Text = femaleTbar.Value
        maleTbar.Value = 100 - femaleTbar.Value
    End Sub
End Class
