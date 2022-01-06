//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "DataBase_Source_2.h"
#include "DataBase_source.h"
#include "DataBase_Source_User.h"
#include "Users.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm2 *Form2;
//---------------------------------------------------------------------------
__fastcall TForm2::TForm2(TComponent* Owner)
	: TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TForm2::Button1Click(TObject *Sender)
{
	ADOQuery1->Delete();
	ADOQuery1->FieldByName("Ad")->Value="";
	ADOQuery1->FieldByName("Soyad")->Value="";
	ADOQuery1->FieldByName("Ixtisas")->Value="";
	ADOQuery1->FieldByName("Qrup")->Value="";
	ADOQuery1->FieldByName("Semestr")->Value="0";
	ADOQuery1->FieldByName("Ortalama")->Value="0";
	ADOQuery1->FieldByName("Teqaud")->Value="0";
	ADOQuery1->Post();
}
//---------------------------------------------------------------------------

void __fastcall TForm2::Button2Click(TObject *Sender)
{
	Form1->Show();
    Form2->Hide();
}
//---------------------------------------------------------------------------

