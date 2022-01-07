//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "TextEditor_source.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
	: TForm(Owner)
{
}
//---------------------------------------------------------------------------
void __fastcall TForm1::newwindow1Click(TObject *Sender)
{
	try{
		Form1 = new TForm1(Application);
		Form1->ShowModal();
		delete Form1;
	}
	catch (Exception& ex){
        ShowMessage(ex.Message);
	}
}
//---------------------------------------------------------------------------



void __fastcall TForm1::Open1Click(TObject *Sender)
{
	try{
		if (OpenDialog1->Execute()){
			RichEdit1->Lines->LoadFromFile(OpenDialog1->FileName);
			Form1->Caption=OpenDialog1->FileName;
			Form1->Caption+=" - Text Editor";
		}
	}
	catch (Exception& ex){
        ShowMessage(ex.Message);
	}
}
//---------------------------------------------------------------------------



void __fastcall TForm1::Save1Click(TObject *Sender)
{
	try{
		if (OpenDialog1->FileName!=""){
			RichEdit1->Lines->SaveToFile(OpenDialog1->FileName);
		}
		else{
			if (SaveDialog1->Execute()){
				RichEdit1->Lines->SaveToFile(SaveDialog1->FileName);
			}
		}
	}
	catch (Exception& ex){
        ShowMessage(ex.Message);
	}
}
//---------------------------------------------------------------------------





void __fastcall TForm1::SaveAs1Click(TObject *Sender)
{
	try{
		if (SaveDialog1->Execute()){
            RichEdit1->Lines->SaveToFile(SaveDialog1->FileName);
		}
	}
	catch (Exception& ex){
        ShowMessage(ex.Message);
	}
}
//---------------------------------------------------------------------------




void __fastcall TForm1::Print1Click(TObject *Sender)
{
	try{
		if (PrintDialog1->Execute()){
            RichEdit1->Print("");
		}
	}
	catch (Exception& ex){
        ShowMessage(ex.Message);
	}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Exit1Click(TObject *Sender)
{
    Application->Terminate();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Undo2Click(TObject *Sender)
{
	RichEdit1->Perform(EM_UNDO,0,0);
}
//---------------------------------------------------------------------------



void __fastcall TForm1::Cut2Click(TObject *Sender)
{
	RichEdit1->CutToClipboard();
}
//---------------------------------------------------------------------------




void __fastcall TForm1::Copy2Click(TObject *Sender)
{
	RichEdit1->CopyToClipboard();
}
//---------------------------------------------------------------------------





void __fastcall TForm1::Paste2Click(TObject *Sender)
{
	RichEdit1->PasteFromClipboard();
}
//---------------------------------------------------------------------------






void __fastcall TForm1::Delete2Click(TObject *Sender)
{
	RichEdit1->ClearSelection();
}
//---------------------------------------------------------------------------




void __fastcall TForm1::SelectAll2Click(TObject *Sender)
{
	RichEdit1->SelectAll();
}
//---------------------------------------------------------------------------





void __fastcall TForm1::Font1Click(TObject *Sender)
{
	try{
		if (FontDialog1->Execute()){
            RichEdit1->Font=FontDialog1->Font;
		}
	}
	catch (Exception& ex){
        ShowMessage(ex.Message);
	}
}
//---------------------------------------------------------------------------

void __fastcall TForm1::About1Click(TObject *Sender)
{
    ShowMessage("This program was developed by Nihad Allahveranov, a student of group 2450a of the National Aviation Academy\nThis program is a text editor.\nWith this program you can create, open and save texts\nThe program has shortcuts to work faster\nIt is possible to change the font of the text\nExtensions supported .txt;.rtf");
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Undo1Click(TObject *Sender)
{
    RichEdit1->Perform(EM_UNDO,0,0);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Cut1Click(TObject *Sender)
{
     RichEdit1->CutToClipboard();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Copy1Click(TObject *Sender)
{
    RichEdit1->CopyToClipboard();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Paste1Click(TObject *Sender)
{
     RichEdit1->PasteFromClipboard();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Delete1Click(TObject *Sender)
{
      RichEdit1->ClearSelection();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::selectall1Click(TObject *Sender)
{
      RichEdit1->SelectAll();
}
//---------------------------------------------------------------------------

