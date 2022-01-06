//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "AudioPlayer_Source.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
	: TForm(Owner)
{
	ListBox2->Visible=False;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::PlayClick(TObject *Sender)
{
	MediaPlayer1->Play();
	Pause->Visible=True;
	Play->Visible=False;
	CheckBox2->Checked=True;
    Timer1->Enabled=true;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::PauseClick(TObject *Sender)
{
	MediaPlayer1->Pause();
	Pause->Visible=False;
	Play->Visible=True;
	Timer1->Enabled=false;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::CheckBox1Click(TObject *Sender)
{
	if(CheckBox1->Checked==True){
		ListBox1->Visible=True;
        ListBox2->Visible=False;
		CheckBox1->Caption="Dark Mode On";
		Background->Visible=True;
	}
	else{
		CheckBox1->Caption="Dark Mode Off";
		ListBox1->Visible=False;
		ListBox2->Visible=True;
		Background->Visible=False;
		Form1->Color=clWhite;
    }
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FolderClick(TObject *Sender)
{
	OpenDialog1->Execute();
	MediaPlayer1->FileName=OpenDialog1->FileName;
	MediaPlayer1->Open();
	CheckBox2->Checked=False;
	Label3->Caption="00:00";
	ListBox1->Items->Add(MediaPlayer1->FileName);
	ListBox2->Items->Add(MediaPlayer1->FileName);
	Label1->Caption=MediaPlayer1->FileName;
	Pause->Visible=False;
	Play->Visible=True;
}
//---------------------------------------------------------------------------


void __fastcall TForm1::ListBox1Click(TObject *Sender)
{
	Label3->Caption="00:00";
	CheckBox2->Checked=false;
	if(ListBox1->ItemIndex!=-1){
		MediaPlayer1->FileName=ListBox1->Items->Strings[ListBox1->ItemIndex];
		MediaPlayer1->Open();
		Play->Visible=true;
        Pause->Visible=false;
		Label1->Caption=MediaPlayer1->FileName;
	}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::ListBox2Click(TObject *Sender)
{
    Label3->Caption="00:00";
	CheckBox2->Checked=false;
	if(ListBox2->ItemIndex!=-1){
		MediaPlayer1->FileName=ListBox2->Items->Strings[ListBox2->ItemIndex];
		MediaPlayer1->Open();
		Play->Visible=true;
		Pause->Visible=false;
		Label1->Caption=MediaPlayer1->FileName;
	}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::ClearClick(TObject *Sender)
{
	  ListBox1->Items->Clear();
	  ListBox2->Items->Clear();
}
//---------------------------------------------------------------------------


void __fastcall TForm1::Timer1Timer(TObject *Sender)
{
	static unsigned long count;
	if (CheckBox2->Checked==true){
		if (count/60==0 && count%60<10){
			String str=count;
			Label3->Caption="00:0"+str;
		}
		else if (count/60==0 && count%60>9){
			String str=count;
			Label3->Caption="00:"+str;
		}
		else if (count/60<10 && count%60<10){
			String str=count/60;
			String str2=count-(count/60)*60;
			Label3->Caption="0"+str+":0"+str2;
		}
		else if (count/60<10 && count%60>9){
			String str=count/60;
			String str2=count-(count/60)*60;
			Label3->Caption="0"+str+":"+str2;
		}
        else if (count/60>9 && count%60<10){
			String str=count/60;
			String str2=count-(count/60)*60;
			Label3->Caption=str+":0"+str2;
		}
		else if (count/60>9 && count%60>9){
			String str=count/60;
			String str2=count-(count/60)*60;
			Label3->Caption=str+":"+str2;
		}
		count++;
	}
	else if (CheckBox2->Checked==false){
		count=0;
		CheckBox2->Checked=true;
		Timer1->Enabled=false;
	}
}
//---------------------------------------------------------------------------
