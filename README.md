USE [Ecommerce]
GO

INSERT INTO [dbo].[Prodotti]
           ([Nome]
           ,[Descrizione]
           ,[Immagine]
           ,[Prezzo])
     VALUES
           ('Maglietta Blu', 'Una maglietta di cotone blu con maniche corte', 'https://encrypted-tbn2.gstatic.com/shopping?q=tbn:ANd9GcQDpoJes4Y-r5sj5ifkV9TTVrr_R9NKT4pba4BTMCVV4Y0ESf8ayXGkJeLPvmvJiWMdw8WIIOMrIwDQxGyK847ZrNWInN_JPNbII_dLPUIZ2JON_Ydab2dxAmOOdzx-UgBgqYW0dbY&usqp=CAc', 19.99),
           ('Jeans Skinny Nero', 'Jeans neri con taglio aderente', 'https://encrypted-tbn2.gstatic.com/shopping?q=tbn:ANd9GcQ7Z-BhgGnDXGr9sKKgfuokZ0JSVUbed_oAalO0XLO9PVr7sv_sCrQf1kiqVMojJ9RPvo6C3R1lKi95G5IGuZV2jdMNIFbINghV9fQ0zvhqr74fx06erke5npCZJTv1uhQFl2jTkA&usqp=CAc', 39.99),
           ('Scarpe da Ginnastica Bianche', 'Scarpe da ginnastica bianche con suola in gomma', 'https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcQYZke-AcxcK_Pe-q8g8Hre-aZF0CttklAE4biYD6ewHoBwxo76qgkFwZvwPEseux06vW_0ufh1OUTl8L3L9Tguv6gmYsGAu4_TI3zekIfnQeU_iySl_ILNin9hLonfUYHGcWStIdcxZg4&usqp=CAc', 29.99),
           ('Cappotto Invernale Grigio', 'Cappotto grigio imbottito per l''inverno', 'https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcSkAIE6PkuQZXp079Zxt6Vn5CIem2qqTfxao-1AIHVBoK0ZRWcw55IZobf4PLh5-8TD5yz9bOAe-Ayy0Uawpbx2IU9mvpnc3Fb_GLAb3gxLmmrmzbHgmEuLBz_8EzOewZ53h4hBVQ&usqp=CAc', 89.99),
           ('Borsa a Tracolla Nera', 'Borsa a tracolla nera in pelle sintetica', 'https://encrypted-tbn0.gstatic.com/shopping?q=tbn:ANd9GcRfn1iWY4XDTw15zs2Y_eQX_9gc-QL_-RSl2T6Rz6kT_rPY4ONkk28MyNlmm2uK-W2SEt7uOZCkrZQIaa-V8gpECrAZlSJn6hqTe90Biuy3KOkA3XhYBRZUqzqwP886x6FdB9qsNScvfg&usqp=CAc', 49.99),
           ('Orologio da Polso Argento', 'Orologio da polso con cinturino argentato', 'https://encrypted-tbn2.gstatic.com/shopping?q=tbn:ANd9GcSlon5HR9gXL8iZW3rQY8sVVatvWM_grZUMPe_ELT90TTLCm95kzMoZddGxumRap7sRAzt95eYX7W9q58V-_vp6MFknfu3ggl8SpfETttExomPOJS8WZlTcTa2PoKIXgFewu-C-4hk&usqp=CAc', 79.99),
           ('Tuta Sportiva Blu', 'Tuta sportiva blu con pantaloni e giacca abbinati', 'https://m.media-amazon.com/images/I/61KvBNhyVVL._AC_SX466_.jpg', 59.99),
           ('Camicia a Righe Bianche e Blu', 'Camicia a righe bianche e blu con colletto button-down', 'https://www.yoox.com/images/items/10/10069214TS_14_f.jpg?impolicy=crop&width=387&height=490', 29.99),
           ('Felpa con Cappuccio Grigia', 'Felpa con cappuccio grigia in misto cotone', 'https://img01.ztat.net/article/spp-media-p1/097a07fcfb7e4537a4cf0d014968090e/1a16ac673c294871b62477b321731956.jpg?imwidth=1800', 34.99),
           ('Pantaloni Chino Beige', 'Pantaloni chino beige in cotone', 'https://blakshop.com/cdn/shop/files/pantaloni-caterpillar-twill-chino-blakshop-53282911977808.jpg?format=pjpg&v=1706450818&width=720', 44.99),
           ('Giacca di Pelle Nera', 'Giacca di pelle nera con zip', 'https://assets.zadig-et-voltaire.com/r/m/rmow00095_anthracite_9.jpg?ixlib=js-3.3.0&auto=format&q=60&w=799', 119.99),
           ('Gonna a Pieghe Blu', 'Gonna a pieghe blu in tessuto leggero', 'https://img1.shopcider.com/product/1688967459000-KJniXc.jpg?x-oss-process=image/resize,w_350,m_lfit/quality,Q_80/interlace,1', 24.99),
           ('Portafoglio in Pelle Marrone', 'Portafoglio da uomo in pelle marrone', 'https://eu-images.contentstack.com/v3/assets/blt7dcd2cfbc90d45de/bltb192bb39e072b7aa/60dbb81047339c0fc01cfd72/5_213.jpg?format=pjpg&auto=webp&quality=75%2C90&width=96', 19.99),
           ('Cappello di Lana Grigio', 'Cappello di lana grigio con risvolto', 'https://lp2.hm.com/hmgoepprod?set=quality%5B79%5D%2Csource%5B%2F63%2Fc5%2F63c5c53004a0faec9bbaccc63de94be2f5c0ee6d.jpg%5D%2Corigin%5Bdam%5D%2Ccategory%5B%5D%2Ctype%5BDESCRIPTIVESTILLLIFE%5D%2Cres%5Bm%5D%2Chmver%5B2%5D&call=url[file:/product/main]', 14.99),
           ('Ombrello Nero', 'Ombrello pieghevole nero con manico in plastica', 'https://image.uniqlo.com/UQ/ST3/WesternCommon/imagesgoods/463746/item/goods_09_463746.jpg?width=60', 9.99);
GO
