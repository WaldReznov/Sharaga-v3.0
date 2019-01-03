<?xml version="1.0" encoding="windows-1251" ?>
<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/">	
	<html>	
		<head> 
			<title>База студентов</title>
		</head>
	</html>	
<font face="Kunstler Script,Tahoma, Helvetica, sans-serif" size="+9">
База студентов
</font>

<table width="100%" border="0" align="center">

<tr bgcolor="#ccddff">
	<td>
		<b>	
		   <font face="Kunstler Script,Tahoma, Helvetica, sans-serif" size="+1">
            Университет
           </font>
		</b>
	</td>
	<td>
		<b>	
		   <font face="Kunstler Script,Tahoma, Helvetica, sans-serif" size="+1">
            ФИО
           </font>
		</b>
	</td>
	
	<td>
		<b><font face="Kunstler Script,Tahoma, Helvetica, sans-serif" size="+1">
            Курс
           </font>
		</b>
	</td>
	<td>
		<b><font face="Kunstler Script,Tahoma, Helvetica, sans-serif" size="+1">
            Группа
           </font>
		</b>
	</td>
	<td>
		<b><font face="Kunstler Script,Tahoma, Helvetica, sans-serif" size="+1">
            Средний балл
           </font>
		</b>
	</td>
<td>
		<b><font face="Kunstler Script,Tahoma, Helvetica, sans-serif" size="+1">
            Форма обучения
           </font>
		</b>
	</td>
<td>
		<b><font face="Kunstler Script,Tahoma, Helvetica, sans-serif" size="+1">
            Факультет
           </font>
		</b>
	</td>
<td>
		<b><font face="Kunstler Script,Tahoma, Helvetica, sans-serif" size="+1">
            Адрес
           </font>
		</b>
	</td>
</tr>
		


<xsl:for-each select="//university">

<tr bgcolor="#ccddff">
	<td>
		<xsl:value-of select="@nameU"/>
	</td>

<xsl:for-each select="student">
<tr bgcolor="#ccddff">
<td></td>
	<font face="sans-serif">
	<td>
		<xsl:value-of select="name/surname"/><xsl:text> </xsl:text>
		<xsl:value-of select="name/first"/><xsl:text> </xsl:text>
		<xsl:value-of select="name/second"/><xsl:text> </xsl:text>
	
	</td>
	<td>
		<xsl:value-of select="cours"/>
	</td>
	<td>
		<xsl:value-of select="group"/>
	</td>
<td>
		<xsl:value-of select="mark"/>
	</td>
<td>
		<xsl:value-of select="form"/>
	</td>
<td>
		<xsl:value-of select="faculty"/>
	</td>
<td>
		<xsl:value-of select="adress"/>
	</td>
	</font>
</tr>
</xsl:for-each>
</tr>

</xsl:for-each>
</table>

	</xsl:template>
	
</xsl:stylesheet>

  