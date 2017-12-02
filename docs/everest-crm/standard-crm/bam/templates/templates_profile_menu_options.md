---
title: Template Profile - Menu Options
---

# Template Profile - Menu Options


To make the template creation easy and user-friendly, pre-defined tags  have been provided. Tags are formats which pick up the actual data values  from the database while displaying the output.


{:.example}
**<#CUSTFIRSTNAME>  is a tag which when used displays the customer's first name in the output.**


You can use the tags in both the subject and body of the template. You  can choose the tags either from the menu or from the tool bar.


The **Templates Profile** menu consists  of the following options:


**[]()Tags**
: Choose this option and you will see the **Tags** browser. The browser displays pre-defined tags that you can use  in your template. Select a tag and click **OK**.  You can also select multiple tags by holding down the Shift or Ctrl  key on your keyboard and clicking on the required records.


**Insert Tags**
: You can also choose tags to be inserted in the template  by using this option. When you select this option, you will see a list  of tags categorized under different headings.


{:.note}
**In the above two options, the tags vary depending  on the event group selected in the [**General**]({{site.crm_baseurl}}/standard-crm/bam/templates/the_templates_profile_general.html) tab of the profile. Different  tags are associated to different event groups. Hence, when a particular  group is selected, the tags pertaining to that group are displayed in  the **Insert Tags** option.**


{:.example}
**You want to send e-mails to your customers,  John and Mary. You can use a tag in your template as "Dear <#CUSTFIRSTNAME>".  When you send the e-mail, the tag is replaced by the customer’s first  name in the output; the output will look as "Dear John" and  "Dear Mary".**


**Format Specifiers**
: Choose this option to specify formats for date,  time, currency or numeric data. This option is usually used in addition  to the tags that you specify. The format specifier should be inserted  before the closing braces of the tag.


{:.example}
**Insert a tag <#SYSCURRDATE>  in your template to display the current system date. If you select the  "mm/dd/yyyy"  format from the **Format Specifier**  option, then the current system date will appear as 07/04/2003 (assuming  that the system date is July 4th, 2003).**
: ![]({{site.crm_baseurl}}/img/lens.gif) [Format  Specifiers]({{site.crm_baseurl}}/misc/format_specifiers.html)


Click [here]({{site.crm_baseurl}}/misc/example_of_a_template.html) for an example of  a template definition with tags and format specifiers.


{:.see_also}
See also
: [The Templates  Profile]({{site.crm_baseurl}}/standard-crm/bam/templates/the_templates_profile.html)
