//---------------------------------------------------------------------------

#ifndef AudioPlayer_SourceH
#define AudioPlayer_SourceH
//---------------------------------------------------------------------------
#include <System.Classes.hpp>
#include <Vcl.Controls.hpp>
#include <Vcl.StdCtrls.hpp>
#include <Vcl.Forms.hpp>
#include <Vcl.ExtCtrls.hpp>
#include <Vcl.Imaging.jpeg.hpp>
#include <Vcl.MPlayer.hpp>
#include <Vcl.Imaging.pngimage.hpp>
#include <Vcl.Dialogs.hpp>
#include <Vcl.ComCtrls.hpp>
#include <Vcl.CheckLst.hpp>
//---------------------------------------------------------------------------
class TForm1 : public TForm
{
__published:	// IDE-managed Components
	TImage *Background;
	TMediaPlayer *MediaPlayer1;
	TLabel *Label1;
	TCheckBox *CheckBox1;
	TImage *Folder;
	TImage *Pause;
	TImage *Play;
	TOpenDialog *OpenDialog1;
	TListBox *ListBox1;
	TListBox *ListBox2;
	TImage *Clear;
	TLabel *Label2;
	TTimer *Timer1;
	TCheckBox *CheckBox2;
	TLabel *Label3;
	void __fastcall PlayClick(TObject *Sender);
	void __fastcall PauseClick(TObject *Sender);
	void __fastcall CheckBox1Click(TObject *Sender);
	void __fastcall FolderClick(TObject *Sender);
	void __fastcall ListBox1Click(TObject *Sender);
	void __fastcall ListBox2Click(TObject *Sender);
	void __fastcall ClearClick(TObject *Sender);
	void __fastcall Timer1Timer(TObject *Sender);
private:	// User declarations
public:		// User declarations
	__fastcall TForm1(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm1 *Form1;
//---------------------------------------------------------------------------
#endif
