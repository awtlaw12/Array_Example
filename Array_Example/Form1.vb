Public Class Form1
    Dim marks() As Integer
    Dim students() As String
    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        Dim totalMarks As Integer = 0
        Dim countMarks As Integer = 0
        Dim minMark As Integer = Integer.MaxValue
        Dim maxMark As Integer = Integer.MinValue

        For Each row As DataGridViewRow In dgvListOfStudents.Rows
            If row.Cells("StudentMarks").Value IsNot Nothing Then
                Dim mark As Integer = CInt(row.Cells("StudentMarks").Value)
                totalMarks += mark
                countMarks += 1
                If mark < minMark Then
                    minMark = mark
                End If
                If mark > maxMark Then
                    maxMark = mark
                End If
            End If
        Next

        If countMarks > 0 Then
            Dim avgScore As Double = totalMarks / countMarks
            Dim resultMsg As String = "Student with the BEST mark: " & maxMark.ToString() & vbCrLf &
                               "Student with the LAST mark: " & minMark.ToString() & vbCrLf &
                               "Average Marks: " & avgScore.ToString("F2")
            MessageBox.Show(resultMsg)
        Else
            MessageBox.Show("No marks found")
        End If
    End Sub


    Private Sub btnAddStudentAndMarks_Click(sender As Object, e As EventArgs) Handles btnAddStudentAndMarks.Click

        Dim studentName As String
        Dim studentMarks As Integer

        studentName = InputBox("Please enter the student's name:")
        studentMarks = CInt(InputBox("Please enter the student's marks:"))

        ' Add the new row to the DataGridView
        dgvListOfStudents.Rows.Add(studentName, studentMarks)

    End Sub

    Private Sub dgvListOfStudents_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListOfStudents.CellContentClick
        For Each row As DataGridViewRow In dgvListOfStudents.Rows
            If Not row.IsNewRow Then
                Dim message As String = ""
                For Each cell As DataGridViewCell In row.Cells
                    message &= cell.Value.ToString() & " "
                Next
                MessageBox.Show(message)
            End If
        Next

    End Sub

    Private Sub btnBest_Click(sender As Object, e As EventArgs) Handles btnBest.Click
        Dim maxMark As Integer
        Dim maxMarkStudentName
        For Each row As DataGridViewRow In dgvListOfStudents.Rows
            If row.Cells("StudentMarks").Value IsNot Nothing AndAlso row.Cells("StudentMarks").Value > maxMark Then
                maxMark = row.Cells("StudentMarks").Value
                maxMarkStudentName = row.Cells("StudentName").Value.ToString()
            End If
        Next

        MessageBox.Show(maxMarkStudentName & " has the maximum marks " & maxMark.ToString())

    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Dim minMark As Integer = Integer.MaxValue
        Dim studentName As String = ""

        For Each row As DataGridViewRow In dgvListOfStudents.Rows
            If row.Cells("StudentMarks").Value IsNot Nothing AndAlso row.Cells("StudentMarks").Value < minMark Then
                minMark = row.Cells("StudentMarks").Value
                studentName = row.Cells("StudentName").Value.ToString()
            End If
        Next

        If minMark = Integer.MaxValue Then
            MessageBox.Show("No marks found")
        Else
            MessageBox.Show(studentName & " has the minimum marks " & minMark.ToString())
        End If
    End Sub


End Class
