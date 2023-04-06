# MongoDB_WebAPI
MongoDb ile WebAPI de gerekli konfigurasyonlar yapılarak CRUD işlemleri gerçekleştirildi.

Mongo Shell ekranında veritabanı oluşturuldu.cmd ekranında aşağıdaki kodları yazarak :

->mongo                         //mongoShell ekranına geçiş

->use eStoreDB                  //eStoreDB isminde veritabanı oluşturma

->db.createCollection("users")  //users collectionı(tablosu) oluşturma

->db.users.insertOne(           //users a kayıt ekleme
  {
    "userNo": 203648,
    "firstName": "Ali",
    "lastName": "Yağız",
    "age": 20,
    "email": "ali@info.com",
    "phone": "0111-111-11-11",
    "city": "İstanbul"
  })

MongoDb veritabanına gerekleştirilen CRUD işlemleri:
![mongodbCRUD](https://user-images.githubusercontent.com/104023688/230297352-4cd91483-0c12-4076-ad7f-29a5d93b9c06.JPG)

User Collectionına ekleme işlemi:
![MongoDbAddİşlemi](https://user-images.githubusercontent.com/104023688/230297244-a21b01fc-ca81-4837-8fb6-f8871cfa06f7.JPG)



