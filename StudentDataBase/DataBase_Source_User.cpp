//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "DataBase_Source_User.h"
#include "DataBase_source.h"
#include "DataBase_Source_2.h"
#include "Users.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm3 *Form3;
//---------------------------------------------------------------------------
__fastcall TForm3::TForm3(TComponent* Owner)
	: TForm(Owner)
{
	Edit5->Visible=False;
	Edit6->Visible=False;
	Edit7->Visible=False;
	Edit8->Visible=False;
	Edit9->Visible=False;
	Edit10->Visible=False;
	Edit11->Visible=False;
	Edit12->Visible=False;
	Edit13->Visible=False;
	Edit14->Visible=False;
	Edit15->Visible=False;
	Edit16->Visible=False;

	Label6->Visible=False;
	Label7->Visible=False;
	Label8->Visible=False;
	Label9->Visible=False;
	Label10->Visible=False;
	Label11->Visible=False;
	Label12->Visible=False;
	Label13->Visible=False;
	Label14->Visible=False;
	Label15->Visible=False;
	Label16->Visible=False;
	Label17->Visible=False;
	Label18->Visible=False;
	Label19->Visible=False;
}
//---------------------------------------------------------------------------



void __fastcall TForm3::CheckBox1Click(TObject *Sender)
{
	if(CheckBox1->Checked==True){
		CheckBox2->Visible=False;
		Edit5->Visible=True;
		Edit6->Visible=True;
		Edit7->Visible=True;
		Edit8->Visible=True;
		Edit9->Visible=True;
		Edit11->Visible=True;
		Edit12->Visible=True;
		Edit13->Visible=True;
		Edit14->Visible=True;
		Edit15->Visible=True;

		Label6->Visible=True;
		Label7->Visible=True;
		Label8->Visible=True;
		Label9->Visible=True;
		Label10->Visible=True;
		Label12->Visible=True;
		Label13->Visible=True;
		Label14->Visible=True;
		Label15->Visible=True;
		Label16->Visible=True;
		Label17->Visible=True;
		Label19->Visible=True;
	}
	else if (CheckBox1->Checked==False){
		CheckBox2->Visible=True;
		Edit5->Visible=False;
		Edit6->Visible=False;
		Edit7->Visible=False;
		Edit8->Visible=False;
		Edit9->Visible=False;
		Edit10->Visible=False;
		Edit11->Visible=False;
		Edit12->Visible=False;
		Edit13->Visible=False;
		Edit14->Visible=False;
		Edit15->Visible=False;
		Edit16->Visible=False;

		Label6->Visible=False;
		Label7->Visible=False;
		Label8->Visible=False;
		Label9->Visible=False;
		Label10->Visible=False;
		Label11->Visible=False;
		Label12->Visible=False;
		Label13->Visible=False;
		Label14->Visible=False;
		Label15->Visible=False;
		Label16->Visible=False;
		Label17->Visible=False;
		Label18->Visible=False;
		Label19->Visible=False;
	}
}
//---------------------------------------------------------------------------

void __fastcall TForm3::CheckBox2Click(TObject *Sender)
{
	if (CheckBox2->Checked==True){
		CheckBox1->Visible=False;
		Edit5->Visible=True;
		Edit6->Visible=True;
		Edit7->Visible=True;
		Edit8->Visible=True;
		Edit9->Visible=True;
		Edit10->Visible=True;
		Edit11->Visible=True;
		Edit12->Visible=True;
		Edit13->Visible=True;
		Edit14->Visible=True;
		Edit15->Visible=True;
		Edit16->Visible=True;

		Label6->Visible=True;
		Label7->Visible=True;
		Label8->Visible=True;
		Label9->Visible=True;
		Label10->Visible=True;
		Label11->Visible=True;
		Label12->Visible=True;
		Label13->Visible=True;
		Label14->Visible=True;
		Label15->Visible=True;
		Label16->Visible=True;
		Label17->Visible=True;
		Label18->Visible=True;
		Label19->Visible=True;
	}
	else if (CheckBox1->Checked==False){
		CheckBox1->Visible=True;
		Edit5->Visible=False;
		Edit6->Visible=False;
		Edit7->Visible=False;
		Edit8->Visible=False;
		Edit9->Visible=False;
		Edit10->Visible=False;
		Edit11->Visible=False;
		Edit12->Visible=False;
		Edit13->Visible=False;
		Edit14->Visible=False;
		Edit15->Visible=False;
		Edit16->Visible=False;

		Label6->Visible=False;
		Label7->Visible=False;
		Label8->Visible=False;
		Label9->Visible=False;
		Label10->Visible=False;
		Label11->Visible=False;
		Label12->Visible=False;
		Label13->Visible=False;
		Label14->Visible=False;
		Label15->Visible=False;
		Label16->Visible=False;
		Label17->Visible=False;
		Label18->Visible=False;
		Label19->Visible=False;
	}
}
//---------------------------------------------------------------------------


void __fastcall TForm3::Button1Click(TObject *Sender)
{
	int b1,b2,b3,b4,b5,k1,k2,k3,k4,k5;
	b1=StrToFloat(Edit5->Text);
	k1=StrToFloat(Edit11->Text);
	b2=StrToFloat(Edit6->Text);
	k2=StrToFloat(Edit12->Text);
	b3=StrToFloat(Edit7->Text);
	k3=StrToFloat(Edit13->Text);
	b4=StrToFloat(Edit8->Text);
	k4=StrToFloat(Edit14->Text);
	b5=StrToFloat(Edit9->Text);
	k5=StrToFloat(Edit15->Text);
	float total  ;
	if (CheckBox2->Checked==True){
		int b6,k6;
		b6=StrToFloat(Edit10->Text);
		k6=StrToFloat(Edit16->Text);
		float totalbk6=b1*k1+b2*k2+b3*k3+b4*k4+b5*k5+b6*k6;
		float totalk6=k1+k2+k3+k4+k5+k6;
		total=totalbk6/totalk6;
		if (b1>=91 && b2>=91 && b3>=91 && b4>=91 && b5>=91 && b6>=91){
			Edit18->Text=130;
			goto label;
		}
		else if (b1>=91 || b2>=91 || b3>=91 || b4>=91 || b5>=91 || b6>=91){
			if (b1>=71 && b2>=71 && b3>=71 && b4>=71 && b5>=71 && b6>=71){
				 Edit18->Text=110;
				 goto label;
			}
		}
		if (b1<51 || b2<51 || b3<51 || b4<51 || b5<51 || b6<51){
			Edit18->Text=0;
			goto label;
		}
        else{
			Edit18->Text=75;
			goto label;
		}
	}
	else if (CheckBox1->Checked==True){
		float totalbk5=b1*k1+b2*k2+b3*k3+b4*k4+b5*k5;
		float totalk5=k1+k2+k3+k4+k5;
		total=totalbk5/totalk5;
		if (b1>=91 && b2>=91 && b3>=91 && b4>=91 && b5>=91){
			Edit18->Text=130;
			goto label;
		}
		else if (b1>=91 || b2>=91 || b3>=91 || b4>=91 || b5>=91){
			if (b1>=71 && b2>=71 && b3>=71 && b4>=71 && b5>=71){
				 Edit18->Text=110;
				 goto label;
			}
		}
		if (b1<51 || b2<51 || b3<51 || b4<51 || b5<51){
			Edit18->Text=0;
			goto label;
		}
        else{
			Edit18->Text=75;
            goto label;
		}
	}
	label:
	ADOQuery1->Insert();
	ADOQuery1->FieldByName("Ad")->Value=Edit1->Text;
	ADOQuery1->FieldByName("Soyad")->Value=Edit2->Text;
	ADOQuery1->FieldByName("Ixtisas")->Value=Edit3->Text;
	ADOQuery1->FieldByName("Qrup")->Value=Edit17->Text;
	ADOQuery1->FieldByName("Semestr")->Value=Edit4->Text;
	ADOQuery1->FieldByName("Ortalama")->Value=total;
	ADOQuery1->FieldByName("Teqaud")->Value=Edit18->Text;
	ADOQuery1->Post();
	Edit1->Clear();
	Edit2->Clear();
	Edit5->Clear();
	Edit6->Clear();
	Edit7->Clear();
	Edit8->Clear();
	Edit9->Clear();
	Edit10->Clear();
	Edit11->Clear();
	Edit12->Clear();
	Edit13->Clear();
	Edit14->Clear();
	Edit15->Clear();
	Edit16->Clear();
	Form4->Show();
}
//---------------------------------------------------------------------------


