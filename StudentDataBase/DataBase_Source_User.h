//---------------------------------------------------------------------------

#ifndef DataBase_Source_UserH
#define DataBase_Source_UserH
//---------------------------------------------------------------------------
#include <System.Classes.hpp>
#include <Vcl.Controls.hpp>
#include <Vcl.StdCtrls.hpp>
#include <Vcl.Forms.hpp>
#include <Data.DB.hpp>
#include <Data.Win.ADODB.hpp>
//---------------------------------------------------------------------------
class TForm3 : public TForm
{
__published:	// IDE-managed Components
	TLabel *Label1;
	TEdit *Edit1;
	TLabel *Label2;
	TEdit *Edit2;
	TLabel *Label3;
	TEdit *Edit3;
	TEdit *Edit4;
	TLabel *Label4;
	TLabel *Label5;
	TCheckBox *CheckBox1;
	TCheckBox *CheckBox2;
	TLabel *Label6;
	TEdit *Edit5;
	TLabel *Label7;
	TLabel *Label8;
	TEdit *Edit6;
	TEdit *Edit7;
	TLabel *Label9;
	TLabel *Label10;
	TLabel *Label11;
	TEdit *Edit8;
	TEdit *Edit9;
	TEdit *Edit10;
	TLabel *Label12;
	TLabel *Label13;
	TLabel *Label14;
	TLabel *Label15;
	TLabel *Label16;
	TLabel *Label17;
	TLabel *Label18;
	TEdit *Edit11;
	TEdit *Edit12;
	TEdit *Edit13;
	TEdit *Edit14;
	TEdit *Edit15;
	TEdit *Edit16;
	TLabel *Label19;
	TButton *Button1;
	TDataSource *DataSource1;
	TADOQuery *ADOQuery1;
	TADOConnection *ADOConnection1;
	TLabel *Label20;
	TEdit *Edit17;
	TEdit *Edit18;
	void __fastcall CheckBox1Click(TObject *Sender);
	void __fastcall CheckBox2Click(TObject *Sender);
	void __fastcall Button1Click(TObject *Sender);
private:	// User declarations
public:		// User declarations
	__fastcall TForm3(TComponent* Owner);
};
//---------------------------------------------------------------------------
extern PACKAGE TForm3 *Form3;
//---------------------------------------------------------------------------
#endif
