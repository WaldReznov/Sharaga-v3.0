<?xml version="1.0" encoding="UTF-8" ?>
<xsl:stylesheet version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">


<xsl:template match="/">	
	<html>	
		<head> 
			<title>Прайс лист</title>
		</head>
		
		<body>
			<a name="home"></a>
			
			<h1> СПИСОК ФИРМ</h1>
			
			<xsl:for-each select="//firm">
				<h2><a href="#firm{position()}">
					<xsl:value-of select="name"/>
				</a></h2>
				<p>
						<xsl:text>Адрес: </xsl:text><br/>
						<xsl:for-each select="adress">
							<p>
							<xsl:value-of select="city"/><xsl:text> </xsl:text>
							<xsl:value-of select="street"/><xsl:text> </xsl:text>
							<xsl:value-of select="house"/><xsl:text> </xsl:text>
							<xsl:value-of select="zip"/><xsl:text> </xsl:text><br/>
							<xsl:text>Телефон:</xsl:text><br/>
							<xsl:for-each select="phone-list">
								<xsl:value-of select="phone"/><br/>
							</xsl:for-each>
							</p>	
						</xsl:for-each>
					
				</p>
			</xsl:for-each>
					
			<h1> ПРАЙС ЛИСТ</h1>		
			
			<xsl:apply-templates />	
			
		</body>
	</html>
</xsl:template>


<xsl:template match="firm">
	<h2>
		<a name="firm{position()}"><xsl:value-of select="name"/></a>
	</h2>
	<xsl:for-each select="good">
		<h3><xsl:value-of select="@name"/><xsl:text> </xsl:text><br/></h3>
		<table width="50%" border="1">
			<tr bgcolor="#CCCCCC">
				<td align="center">
					<strong>Модель</strong>
				</td>
				<td align="center">
					<strong>Параметры</strong>
				</td>
				<td align="center">
					<strong>Цена</strong>
					</td>
				</tr>
				<xsl:for-each select="description">
					<tr bgcolor="#F5F5F5">
					<td align="center">
						<strong>
							<xsl:value-of select="model"/>
						</strong>
					</td>
					<td align="center">
						<strong>
							<xsl:value-of select="parametrs"/>
						</strong>
					</td>
					<td align="center">
						<strong>
							<xsl:value-of select="price"/>
						</strong>
					</td>
				</tr>
				</xsl:for-each>
		</table>
	
	</xsl:for-each>

	<a href="#home">На первую страницу</a>

	</xsl:template>


</xsl:stylesheet>


  