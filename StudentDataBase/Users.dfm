object Form4: TForm4
  Left = 0
  Top = 0
  Caption = 'SDB'
  ClientHeight = 400
  ClientWidth = 600
  Color = clWindowFrame
  Constraints.MaxHeight = 450
  Constraints.MaxWidth = 650
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  Icon.Data = {
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF00FFFFFFFFFFFFFFFFFFF
    FFFFFFFFF000000FFFFFFFFFFFFFFFFFFFFFFFFF00000000FFFFFFFFFFFFFFFF
    FFFFFFF8000000001FFFFFFFFFFFFFFFFFFFFFC00000000003FFFFFFFFFFFFFF
    FFFFFE0000000000007FFFFFFFFFFFFFFFFFF80000000000001FFFFFFFFFFFFF
    FFFFE000000000000007FFFFFFFFFFFFFFFF8000000000000001FFFFFFFFFFFF
    FFFE00000000000000007FFFFFFFFFFFFFFC00000000000000003FFFFFFFFFFF
    FFF000000000000000000FFFFFFFFFFFFFE0000000000000000007FFFFFFFFFF
    FF80000000000000000001FFFFFFFFFFFF00000000000000000000FFFFFFFFFF
    FE000000000000000000007FFFFFFFFFF8000000000000000000001FFFFFFFFF
    F0000000000000000000000FFFFFFFFFE0000000003FFC0000000007FFFFFFFF
    C000000001FFFF8000000003FFFFFFFF8000000007FFFFE000000001FFFFFFFE
    000000001FFFFFF8000000007FFFFFFC000000003FFFFFFC000000003FFFFFF8
    000000007FFFFFFE000000001FFFFFF000000000FFFFFFFF000000000FFFFFE0
    00000001FFFFFFFF8000000007FFFFE000000003FFFFFFFFC000000007FFFFC0
    00000007FFFFFFFFE000000003FFFF800000000FFFFFFFFFF000000001FFFF00
    0000000FFFFFFFFFF000000000FFFE000000001FFFFFFFFFF8000000007FFC00
    0000001FFFFFFFFFF8000000003FF8000000003FFFFFFFFFFC000000001FF800
    0000003FFFF00FFFFC000000001FF0000000003FFFC003FFFC000000000FE000
    0000007FFF8001FFFE0000000007C0000000007FFF8001FFFE0000000003C000
    0000007FFF0000FFFE000000000380000000007FFF0000FFFE00000000010000
    0000007FFF0000FFFE000000000000000000007FFF0000FFFE00000000000000
    0000007FFF0000FFFE000000000000000000007FFF0000FFFE00000000008000
    0000007FFF0000FFFE0000000001C0000000007FFF0000FFFE0000000003C000
    0000007FFF8001FFFE0000000003E0000000007FFF8001FFFE0000000007F000
    0000007FFFC003FFFE000000000FF0000000003FFFF00FFFFC000000000FF800
    0000003FFFFE7FFFFC000000001FFC000000001FFFFFFFFFF8000000003FFE00
    0000001FFFFFFFFFF8000000007FFF000000000FFFFFFFFFF000000000FFFF80
    0000000FFFFFFFFFF000000001FFFFC000000007FFFFFFFFE000000003FFFFC0
    00000003FFFFFFFFC000000003FFFFE000000003FFFFFFFFC000000007FFFFF0
    00000001FFFFFFFF800000000FFFFFF800000000FFFFFFFF000000001FFFFFFC
    000000003FFFFFFC000000003FFFFFFE000000001FFFFFF8000000007FFFFFFF
    0000000007FFFFE000000000FFFFFFFFC000000001FFFF8000000003FFFFFFFF
    E0000000007FFE0000000007FFFFFFFFF0000000000180000000000FFFFFFFFF
    F8000000000000000000001FFFFFFFFFFC000000000000000000003FFFFFFFFF
    FF00000000000000000000FFFFFFFFFFFF80000000000000000001FFFFFFFFFF
    FFE0000000000000000007FFFFFFFFFFFFF000000000000000000FFFFFFFFFFF
    FFFC00000000000000003FFFFFFFFFFFFFFE00000000000000007FFFFFFFFFFF
    FFFF8000000000000001FFFFFFFFFFFFFFFFE000000000000007FFFFFFFFFFFF
    FFFFF80000000000001FFFFFFFFFFFFFFFFFFE0000000000007FFFFFFFFFFFFF
    FFFFFFC00000000003FFFFFFFFFFFFFFFFFFFFF8000000001FFFFFFFFFFFFFFF
    FFFFFFFF00000000FFFFFFFFFFFFFFFFFFFFFFFFF000000FFFFFFFFFFFFFFFFF
    FFFFFFFFFFF00FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF
    FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF}
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object DBGrid1: TDBGrid
    Left = 0
    Top = 0
    Width = 600
    Height = 400
    Align = alClient
    BiDiMode = bdLeftToRight
    Color = clWindowFrame
    DataSource = Form3.DataSource1
    FixedColor = clWindowFrame
    GradientEndColor = clWindowFrame
    GradientStartColor = clWindowFrame
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -13
    Font.Name = 'Tahoma'
    Font.Style = []
    ParentBiDiMode = False
    ParentFont = False
    ReadOnly = True
    TabOrder = 0
    TitleFont.Charset = DEFAULT_CHARSET
    TitleFont.Color = clWindowText
    TitleFont.Height = -11
    TitleFont.Name = 'Tahoma'
    TitleFont.Style = []
    Columns = <
      item
        Alignment = taCenter
        Color = clWindowFrame
        Expanded = False
        FieldName = 'ID'
        Width = 15
        Visible = True
      end
      item
        Alignment = taCenter
        Color = clWindowFrame
        Expanded = False
        FieldName = 'Ad'
        Width = 75
        Visible = True
      end
      item
        Alignment = taCenter
        Color = clWindowFrame
        Expanded = False
        FieldName = 'Soyad'
        Width = 100
        Visible = True
      end
      item
        Alignment = taCenter
        Color = clWindowFrame
        Expanded = False
        FieldName = 'Ixtisas'
        Width = 150
        Visible = True
      end
      item
        Alignment = taCenter
        Color = clWindowFrame
        Expanded = False
        FieldName = 'Qrup'
        Width = 50
        Visible = True
      end
      item
        Alignment = taCenter
        Color = clWindowFrame
        Expanded = False
        FieldName = 'Semestr'
        Width = 50
        Visible = True
      end
      item
        Alignment = taCenter
        Color = clWindowFrame
        Expanded = False
        FieldName = 'Ortalama'
        Width = 50
        Visible = True
      end
      item
        Alignment = taCenter
        Color = clWindowFrame
        Expanded = False
        FieldName = 'Teqaud'
        Width = 70
        Visible = True
      end>
  end
end
