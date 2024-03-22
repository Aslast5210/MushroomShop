# MushroomPop
### ความเป็นมาของโปรแกรม
โปรแกรมนี้ คือ โปรแกรมการซื้อขาย "เห็ด" มาจากการที่ ที่บ้านผมมีธุระกิจฟาร์มเพาะเห็ด แต่ยังไม่มีการบันทึกการซื้อขายเห็ดที่เป็นดิจิตอล 

<br/><br/>
### วัตถุประสงค์ของโปรแกรม
เพื่อให้คนที่บ้านสามารถใช้โปรแกรมซื้อขายเห็ด ซึ่งสะดวกกว่าการจดบันทึกบนสมุด

<br/><br/>
### โครงสร้างของโปรแกรม (Class diagram)
```mermaid
classDiagram
    Program <|-- MushroomShop
    MushroomShop <|-- Sale
    MushroomShop <|-- Mush
    MushroomShop <|-- Customer
    Program : +Main()
    class MushroomShop{
        +button1_Click()
        +button2_Click()
        +salebutt_Click()
        +saveToolStripMenuItem1_Click()
        +fileToolStripMenuItem_Click()
        +Cancelbutton_Click()
    }
    class Customer{
        -Name : string
        -Address  : string
        -PhoneNumber : string
    }
    class Mush{
        -Type : string 
        -Weight : string 
        -Price : string 
    }
    class Sale{
        +GetPrice(string type, double weight) double
    }
    
```

<br/><br/>
### ชื่อของผู้พัฒนาโปรแกรม
663450353-1 นายเทพทินกร พรมโสภา
