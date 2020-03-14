<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NordChecker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NordChecker))
        Me.ProxylessChecker = New NordVPNProxylessChecker.ThirteenForm()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.CreatorLabel = New System.Windows.Forms.Label()
        Me.TopMostToggle = New System.Windows.Forms.CheckBox()
        Me.MinimizeButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.StartStopButton = New NordVPNProxylessChecker.ThirteenButton()
        Me.ImportComboButton = New NordVPNProxylessChecker.ThirteenButton()
        Me.AOTLabel = New System.Windows.Forms.Label()
        Me.ResultsLabel = New System.Windows.Forms.Label()
        Me.ThreadBox = New NordVPNProxylessChecker.ThirteenTextBox()
        Me.ResultsPanel = New System.Windows.Forms.Panel()
        Me.CheckedAmount = New System.Windows.Forms.Label()
        Me.ErrorsAmount = New System.Windows.Forms.Label()
        Me.BadHitsAmount = New System.Windows.Forms.Label()
        Me.GoodHitsAmount = New System.Windows.Forms.Label()
        Me.ComboAmount = New System.Windows.Forms.Label()
        Me.CheckedLabel = New System.Windows.Forms.Label()
        Me.ErrorsLabel = New System.Windows.Forms.Label()
        Me.BadHitsLabel = New System.Windows.Forms.Label()
        Me.GoodHitsLabel = New System.Windows.Forms.Label()
        Me.ComboAmountLabel = New System.Windows.Forms.Label()
        Me.ResultsBox = New NordVPNProxylessChecker.ThirteenTextBox()
        Me.ProxylessChecker.SuspendLayout()
        Me.BottomPanel.SuspendLayout()
        Me.ResultsPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProxylessChecker
        '
        Me.ProxylessChecker.AccentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProxylessChecker.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ProxylessChecker.ColorScheme = NordVPNProxylessChecker.ThirteenForm.ColorSchemes.Dark
        Me.ProxylessChecker.Controls.Add(Me.BottomPanel)
        Me.ProxylessChecker.Controls.Add(Me.TopMostToggle)
        Me.ProxylessChecker.Controls.Add(Me.MinimizeButton)
        Me.ProxylessChecker.Controls.Add(Me.CloseButton)
        Me.ProxylessChecker.Controls.Add(Me.StartStopButton)
        Me.ProxylessChecker.Controls.Add(Me.ImportComboButton)
        Me.ProxylessChecker.Controls.Add(Me.AOTLabel)
        Me.ProxylessChecker.Controls.Add(Me.ResultsLabel)
        Me.ProxylessChecker.Controls.Add(Me.ThreadBox)
        Me.ProxylessChecker.Controls.Add(Me.ResultsPanel)
        Me.ProxylessChecker.Controls.Add(Me.ResultsBox)
        Me.ProxylessChecker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProxylessChecker.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ProxylessChecker.ForeColor = System.Drawing.Color.White
        Me.ProxylessChecker.Location = New System.Drawing.Point(0, 0)
        Me.ProxylessChecker.Name = "ProxylessChecker"
        Me.ProxylessChecker.Size = New System.Drawing.Size(616, 396)
        Me.ProxylessChecker.TabIndex = 0
        Me.ProxylessChecker.Text = "NordVPN Proxyless Checker"
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BottomPanel.Controls.Add(Me.CreatorLabel)
        Me.BottomPanel.Location = New System.Drawing.Point(1, 376)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(614, 18)
        Me.BottomPanel.TabIndex = 12
        '
        'CreatorLabel
        '
        Me.CreatorLabel.AutoSize = True
        Me.CreatorLabel.Font = New System.Drawing.Font("Yu Gothic UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreatorLabel.Location = New System.Drawing.Point(2, 2)
        Me.CreatorLabel.Name = "CreatorLabel"
        Me.CreatorLabel.Size = New System.Drawing.Size(76, 13)
        Me.CreatorLabel.TabIndex = 13
        Me.CreatorLabel.Text = "Made by SS75"
        '
        'TopMostToggle
        '
        Me.TopMostToggle.AutoSize = True
        Me.TopMostToggle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TopMostToggle.FlatAppearance.BorderSize = 0
        Me.TopMostToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TopMostToggle.Location = New System.Drawing.Point(417, 4)
        Me.TopMostToggle.Name = "TopMostToggle"
        Me.TopMostToggle.Size = New System.Drawing.Size(75, 21)
        Me.TopMostToggle.TabIndex = 11
        Me.TopMostToggle.Text = "Top Most"
        Me.TopMostToggle.UseVisualStyleBackColor = True
        '
        'MinimizeButton
        '
        Me.MinimizeButton.FlatAppearance.BorderSize = 0
        Me.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinimizeButton.Location = New System.Drawing.Point(500, 1)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(56, 28)
        Me.MinimizeButton.TabIndex = 10
        Me.MinimizeButton.Text = "Mini"
        Me.MinimizeButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Location = New System.Drawing.Point(559, 1)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(56, 28)
        Me.CloseButton.TabIndex = 9
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'StartStopButton
        '
        Me.StartStopButton.AccentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StartStopButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.StartStopButton.ColorScheme = NordVPNProxylessChecker.ThirteenButton.ColorSchemes.Dark
        Me.StartStopButton.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.StartStopButton.ForeColor = System.Drawing.Color.White
        Me.StartStopButton.Location = New System.Drawing.Point(77, 110)
        Me.StartStopButton.Name = "StartStopButton"
        Me.StartStopButton.Size = New System.Drawing.Size(132, 31)
        Me.StartStopButton.TabIndex = 8
        Me.StartStopButton.Text = "Start"
        Me.StartStopButton.UseVisualStyleBackColor = False
        '
        'ImportComboButton
        '
        Me.ImportComboButton.AccentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ImportComboButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ImportComboButton.ColorScheme = NordVPNProxylessChecker.ThirteenButton.ColorSchemes.Dark
        Me.ImportComboButton.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ImportComboButton.ForeColor = System.Drawing.Color.White
        Me.ImportComboButton.Location = New System.Drawing.Point(77, 57)
        Me.ImportComboButton.Name = "ImportComboButton"
        Me.ImportComboButton.Size = New System.Drawing.Size(132, 31)
        Me.ImportComboButton.TabIndex = 7
        Me.ImportComboButton.Text = "Import Combos"
        Me.ImportComboButton.UseVisualStyleBackColor = False
        '
        'AOTLabel
        '
        Me.AOTLabel.AutoSize = True
        Me.AOTLabel.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AOTLabel.Location = New System.Drawing.Point(73, 158)
        Me.AOTLabel.Name = "AOTLabel"
        Me.AOTLabel.Size = New System.Drawing.Size(136, 20)
        Me.AOTLabel.TabIndex = 6
        Me.AOTLabel.Text = "Amount of Threads"
        '
        'ResultsLabel
        '
        Me.ResultsLabel.AutoSize = True
        Me.ResultsLabel.Font = New System.Drawing.Font("Yu Gothic UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultsLabel.Location = New System.Drawing.Point(418, 37)
        Me.ResultsLabel.Name = "ResultsLabel"
        Me.ResultsLabel.Size = New System.Drawing.Size(55, 20)
        Me.ResultsLabel.TabIndex = 5
        Me.ResultsLabel.Text = "Results"
        '
        'ThreadBox
        '
        Me.ThreadBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ThreadBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ThreadBox.ColorScheme = NordVPNProxylessChecker.ThirteenTextBox.ColorSchemes.Dark
        Me.ThreadBox.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ThreadBox.ForeColor = System.Drawing.Color.White
        Me.ThreadBox.Location = New System.Drawing.Point(23, 181)
        Me.ThreadBox.Name = "ThreadBox"
        Me.ThreadBox.Size = New System.Drawing.Size(237, 25)
        Me.ThreadBox.TabIndex = 2
        Me.ThreadBox.Text = "10"
        Me.ThreadBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ResultsPanel
        '
        Me.ResultsPanel.Controls.Add(Me.CheckedAmount)
        Me.ResultsPanel.Controls.Add(Me.ErrorsAmount)
        Me.ResultsPanel.Controls.Add(Me.BadHitsAmount)
        Me.ResultsPanel.Controls.Add(Me.GoodHitsAmount)
        Me.ResultsPanel.Controls.Add(Me.ComboAmount)
        Me.ResultsPanel.Controls.Add(Me.CheckedLabel)
        Me.ResultsPanel.Controls.Add(Me.ErrorsLabel)
        Me.ResultsPanel.Controls.Add(Me.BadHitsLabel)
        Me.ResultsPanel.Controls.Add(Me.GoodHitsLabel)
        Me.ResultsPanel.Controls.Add(Me.ComboAmountLabel)
        Me.ResultsPanel.Location = New System.Drawing.Point(23, 216)
        Me.ResultsPanel.Name = "ResultsPanel"
        Me.ResultsPanel.Size = New System.Drawing.Size(237, 144)
        Me.ResultsPanel.TabIndex = 1
        '
        'CheckedAmount
        '
        Me.CheckedAmount.AutoSize = True
        Me.CheckedAmount.Location = New System.Drawing.Point(159, 116)
        Me.CheckedAmount.Name = "CheckedAmount"
        Me.CheckedAmount.Size = New System.Drawing.Size(15, 17)
        Me.CheckedAmount.TabIndex = 9
        Me.CheckedAmount.Text = "0"
        '
        'ErrorsAmount
        '
        Me.ErrorsAmount.AutoSize = True
        Me.ErrorsAmount.ForeColor = System.Drawing.Color.Orange
        Me.ErrorsAmount.Location = New System.Drawing.Point(159, 90)
        Me.ErrorsAmount.Name = "ErrorsAmount"
        Me.ErrorsAmount.Size = New System.Drawing.Size(15, 17)
        Me.ErrorsAmount.TabIndex = 8
        Me.ErrorsAmount.Text = "0"
        '
        'BadHitsAmount
        '
        Me.BadHitsAmount.AutoSize = True
        Me.BadHitsAmount.ForeColor = System.Drawing.Color.Red
        Me.BadHitsAmount.Location = New System.Drawing.Point(159, 62)
        Me.BadHitsAmount.Name = "BadHitsAmount"
        Me.BadHitsAmount.Size = New System.Drawing.Size(15, 17)
        Me.BadHitsAmount.TabIndex = 7
        Me.BadHitsAmount.Text = "0"
        '
        'GoodHitsAmount
        '
        Me.GoodHitsAmount.AutoSize = True
        Me.GoodHitsAmount.ForeColor = System.Drawing.Color.Lime
        Me.GoodHitsAmount.Location = New System.Drawing.Point(159, 35)
        Me.GoodHitsAmount.Name = "GoodHitsAmount"
        Me.GoodHitsAmount.Size = New System.Drawing.Size(15, 17)
        Me.GoodHitsAmount.TabIndex = 6
        Me.GoodHitsAmount.Text = "0"
        '
        'ComboAmount
        '
        Me.ComboAmount.AutoSize = True
        Me.ComboAmount.Location = New System.Drawing.Point(159, 9)
        Me.ComboAmount.Name = "ComboAmount"
        Me.ComboAmount.Size = New System.Drawing.Size(15, 17)
        Me.ComboAmount.TabIndex = 5
        Me.ComboAmount.Text = "0"
        '
        'CheckedLabel
        '
        Me.CheckedLabel.AutoSize = True
        Me.CheckedLabel.Location = New System.Drawing.Point(8, 116)
        Me.CheckedLabel.Name = "CheckedLabel"
        Me.CheckedLabel.Size = New System.Drawing.Size(59, 17)
        Me.CheckedLabel.TabIndex = 4
        Me.CheckedLabel.Text = "Checked:"
        '
        'ErrorsLabel
        '
        Me.ErrorsLabel.AutoSize = True
        Me.ErrorsLabel.Location = New System.Drawing.Point(8, 90)
        Me.ErrorsLabel.Name = "ErrorsLabel"
        Me.ErrorsLabel.Size = New System.Drawing.Size(42, 17)
        Me.ErrorsLabel.TabIndex = 3
        Me.ErrorsLabel.Text = "Errors:"
        '
        'BadHitsLabel
        '
        Me.BadHitsLabel.AutoSize = True
        Me.BadHitsLabel.Location = New System.Drawing.Point(8, 62)
        Me.BadHitsLabel.Name = "BadHitsLabel"
        Me.BadHitsLabel.Size = New System.Drawing.Size(32, 17)
        Me.BadHitsLabel.TabIndex = 2
        Me.BadHitsLabel.Text = "Bad:"
        '
        'GoodHitsLabel
        '
        Me.GoodHitsLabel.AutoSize = True
        Me.GoodHitsLabel.Location = New System.Drawing.Point(8, 35)
        Me.GoodHitsLabel.Name = "GoodHitsLabel"
        Me.GoodHitsLabel.Size = New System.Drawing.Size(41, 17)
        Me.GoodHitsLabel.TabIndex = 1
        Me.GoodHitsLabel.Text = "Good:"
        '
        'ComboAmountLabel
        '
        Me.ComboAmountLabel.AutoSize = True
        Me.ComboAmountLabel.Location = New System.Drawing.Point(8, 9)
        Me.ComboAmountLabel.Name = "ComboAmountLabel"
        Me.ComboAmountLabel.Size = New System.Drawing.Size(56, 17)
        Me.ComboAmountLabel.TabIndex = 0
        Me.ComboAmountLabel.Text = "Combos:"
        '
        'ResultsBox
        '
        Me.ResultsBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ResultsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ResultsBox.ColorScheme = NordVPNProxylessChecker.ThirteenTextBox.ColorSchemes.Dark
        Me.ResultsBox.Font = New System.Drawing.Font("Segoe UI Semilight", 9.75!)
        Me.ResultsBox.ForeColor = System.Drawing.Color.White
        Me.ResultsBox.Location = New System.Drawing.Point(282, 62)
        Me.ResultsBox.Multiline = True
        Me.ResultsBox.Name = "ResultsBox"
        Me.ResultsBox.ReadOnly = True
        Me.ResultsBox.Size = New System.Drawing.Size(322, 306)
        Me.ResultsBox.TabIndex = 3
        Me.ResultsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NordChecker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 396)
        Me.Controls.Add(Me.ProxylessChecker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NordChecker"
        Me.Text = "NordVPN Proxyless Checker"
        Me.ProxylessChecker.ResumeLayout(False)
        Me.ProxylessChecker.PerformLayout()
        Me.BottomPanel.ResumeLayout(False)
        Me.BottomPanel.PerformLayout()
        Me.ResultsPanel.ResumeLayout(False)
        Me.ResultsPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProxylessChecker As ThirteenForm
    Friend WithEvents ResultsBox As ThirteenTextBox
    Friend WithEvents StartStopButton As ThirteenButton
    Friend WithEvents ImportComboButton As ThirteenButton
    Friend WithEvents AOTLabel As Label
    Friend WithEvents ResultsLabel As Label
    Friend WithEvents ThreadBox As ThirteenTextBox
    Friend WithEvents ResultsPanel As Panel
    Friend WithEvents CheckedAmount As Label
    Friend WithEvents ErrorsAmount As Label
    Friend WithEvents BadHitsAmount As Label
    Friend WithEvents GoodHitsAmount As Label
    Friend WithEvents ComboAmount As Label
    Friend WithEvents CheckedLabel As Label
    Friend WithEvents ErrorsLabel As Label
    Friend WithEvents BadHitsLabel As Label
    Friend WithEvents GoodHitsLabel As Label
    Friend WithEvents ComboAmountLabel As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents MinimizeButton As Button
    Friend WithEvents TopMostToggle As CheckBox
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents CreatorLabel As Label
End Class
