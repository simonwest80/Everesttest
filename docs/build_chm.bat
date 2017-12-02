if not exist ".\out" mkdir ".\out"

call jekyll.bat b --config _chm-config.yml
IF %ERRORLEVEL% NEQ 0 GOTO FAIL

hhc _site\working-with-everest\working-with-everest.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\working-with-everest\working-with-everest.chm bin\working-with-everest.chm

hhc _site\setting-up-a-company\setting-up-a-company.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\setting-up-a-company\setting-up-a-company.chm bin\setting-up-a-company.chm

hhc _site\business-processes-in-everest\business-processes.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\business-processes-in-everest\business-processes.chm bin\business-processes.chm

hhc _site\forms-designer\forms_designer.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\forms-designer\forms_designer.chm bin\forms_designer.chm

hhc _site\managing-items\managing-items.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\managing-items\managing-items.chm bin\managing-items.chm

hhc _site\managing-vendors\managing-vendors.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\managing-vendors\managing-vendors.chm bin\managing-vendors.chm

hhc _site\managing-customers\managing-customers.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\managing-customers\managing-customers.chm bin\managing-customers.chm

hhc _site\custom-tracking\custom-tracking.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\custom-tracking\custom-tracking.chm bin\custom-tracking.chm

hhc _site\the-purchase-process\the-purchase-process.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\the-purchase-process\the-purchase-process.chm bin\the-purchase-process.chm

hhc _site\building-assemblies\building-assemblies.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\building-assemblies\building-assemblies.chm bin\building-assemblies.chm

hhc _site\warehouse-management\warehouse-management.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\warehouse-management\warehouse-management.chm bin\warehouse-management.chm

hhc _site\sales\the-sales-process.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\sales\the-sales-process.chm bin\the-sales-process.chm

hhc _site\point-of-sale\point-of-sale.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\point-of-sale\point-of-sale.chm bin\point-of-sale.chm

hhc _site\contact-manager\contact-manager.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\contact-manager\contact-manager.chm bin\contact-manager.chm

hhc _site\time-clock\time-clock.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\time-clock\time-clock.chm bin\time-clock.chm

hhc _site\accounting\accounting.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\accounting\accounting.chm bin\accounting.chm

hhc _site\utilities\utility.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\utilities\utility.chm bin\utility.chm

hhc _site\everest-advanced-dashboard\Everest_Advanced_Dashboard.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\everest-advanced-dashboard\Everest_Advanced_Dashboard.chm bin\Everest_Advanced_Dashboard.chm

hhc _site\reports\reports.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\reports\reports.chm bin\reports.chm

hhc _site\reports-manager\report-manager.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\reports-manager\report-manager.chm bin\report-manager.chm

hhc _site\everest-us-payroll\everest-us-payroll.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\everest-us-payroll\everest-us-payroll.chm bin\everest-us-payroll.chm

hhc _site\everest-e-mail\everest-e-mail.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\everest-e-mail\everest-e-mail.chm bin\everest-e-mail.chm

hhc _site\everest-mailbridge\mailbridge.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\everest-mailbridge\mailbridge.chm bin\mailbridge.chm

hhc _site\everest-crm\acrm.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\everest-crm\acrm.chm bin\acrm.chm

hhc _site\everest-advanced-edition-utilities\everest-advanced-edition-utilities.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\everest-advanced-edition-utilities\everest-advanced-edition-utilities.chm bin\everest-advanced-edition-utilities.chm

hhc _site\glossary\Everest_Advance_Edition_Glossary.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\glossary\Everest_Advance_Edition_Glossary.chm bin\Everest_Advance_Edition_Glossary.chm

hhc _site\about-online-help\about-online-help.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL
move _site\about-online-help\about-online-help.chm bin\about-online-help.chm


hhc bin\Everest_Help.hhp
IF %ERRORLEVEL% NEQ 1 GOTO FAIL

pause
exit


:FAIL
echo "ERROR"
pause
exit