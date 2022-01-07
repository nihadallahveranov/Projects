//---------------------------------------------------------------------------

#ifndef TextEditor_sourceH
#define TextEditor_sourceH
//---------------------------------------------------------------------------
#include <System.Classes.hpp>
#include <Vcl.Controls.hpp>
#include <Vcl.StdCtrls.hpp>
#include <Vcl.Forms.hpp>
#include <Vcl.ComCtrls.hpp>
#include <Vcl.Menus.hpp>
#include <Vcl.Dialogs.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
	TScrollBox *ScrollBox1;
	TRichEdit *RichEdit1;
	TMainMenu *MainMenu1;
	TPopupMenu *PopupMenu1;
	TMenuItem *File1;
	TMenuItem *newwindow1;
	TMenuItem *Open1;
	TMenuItem *Save1;
	TMenuItem *SaveAs1;
	TMenuItem *N1;
	TMenuItem *Print1;
	TMenuItem *N2;
	TMenuItem *Exit1;
	TMenuItem *Undo1;
	TMenuItem *N3;
	TMenuItem *Cut1;
	TMenuItem *Copy1;
	TMenuItem *Paste1;
	TMenuItem *Delete1;
	TMenuItem *N4;
	TMenuItem *selectall1;
	TMenuItem *Edit1;
	TMenuItem *Undo2;
	TMenuItem *N5;
	TMenuItem *Cut2;
	TMenuItem *Copy2;
	TMenuItem *Paste2;
	TMenuItem *Delete2;
	TMenuItem *N6;
	TMenuItem *SelectAll2;
	TOpenDialog *OpenDialog1;
	TSaveDialog *SaveDialog1;
	TPrintDialog *PrintDialog1;
	TMenuItem *Format1;
	TMenuItem *Font1;
	TFontDialog *FontDialog1;
	TMenuItem *Help1;
	TMenuItem *About1;
	void __fastcall newwindow1Click(TObject *Sender);
	void __fastcall Open1Click(TObject *Sender);
	void __fastcall Save1Click(TObject *Sender);
	void __fastcall SaveAs1Click(TObject *Sender);
	void __fastcall Print1Click(TObject *Sender);
	void __fastcall Exit1Click(TObject *Sender);
	void __fastcall Undo2Click(TObject *Sender);
	void __fastcall Cut2Click(TObject *Sender);
	void __fastcall Copy2Click(TObject *Sender);
	void __fastcall Paste2Click(TObject *Sender);
	void __fastcall Delete2Click(TObject *Sender);
	void __fastcall SelectAll2Click(TObject *Sender);
	void __fastcall Font1Click(TObject *Sender);
	void __fastcall About1Click(TObject *Sender);
	void __fastcall Undo1Click(TObject *Sender);
	void __fastcall Cut1Click(TObject *Sender);
	void __fastcall Copy1Click(TObject *Sender);
	void __fastcall Paste1Click(TObject *Sender);
	void __fastcall Delete1Click(TObject *Sender);
	void __fastcall selectall1Click(TObject *Sender);
private:	// User declarations
public:		// User declarations
	__fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
