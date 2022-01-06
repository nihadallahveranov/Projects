//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "DataBase_source.h"
#include "DataBase_Source_2.h"
#include "DataBase_Source_User.h"
#include "Users.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
	: TForm(Owner)
{
	Edit1->Visible=False;
	Log->Visible=False;
	Password->Visible=False;
}
//---------------------------------------------------------------------------
//---------------------------------------------------------------------------
void __fastcall TForm1::LogClick(TObject *Sender)
{
    if (Edit1->Text=="123"){
		Form2->Show();
		Edit1->Clear();
		Form1->Hide();
	}
	else{
		ShowMessage("!!Wrong Password!!")   ;
		Edit1->Clear();
	}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::AdminClick(TObject *Sender)
{
	Edit1->Visible=True;
	Password->Visible=True;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::UserClick(TObject *Sender)
{
	Form1->Hide();
    Form3->Show();
}
//---------------------------------------------------------------------------


void __fastcall TForm1::Edit1Change(TObject *Sender)
{
	Edit1->PasswordChar='*';
    Log->Visible=True;
}
//---------------------------------------------------------------------------

