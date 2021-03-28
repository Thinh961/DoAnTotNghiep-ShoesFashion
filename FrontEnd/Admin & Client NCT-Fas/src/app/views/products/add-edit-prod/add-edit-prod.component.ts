import { Component, OnInit,Input } from '@angular/core';
import { SharedService } from "../../../_services/shared.service"
import { ShowProdComponent } from "../show-prod/show-prod.component"

@Component({
  selector: 'app-add-edit-prod',
  templateUrl: './add-edit-prod.component.html',
  styleUrls: ['./add-edit-prod.component.scss']
})
export class AddEditProdComponent implements OnInit {

  SupplierList:any=[];
  CategoryList:any=[];

  constructor(
    private service:SharedService,
    private showProd:ShowProdComponent
  ) { }

  @Input() products:any;
    id:string;
    productName:string;
    categoryId:string;
    supplierId:string;
    image:string;
    createDate:string;
    updateDate:string;
    description:string;
    shortName:string;
    startSale:string;
    endSale:string;

  ngOnInit() {
    this.showProd.refreshProdList();
    this.refreshSuppList();
    this.refreshCategoList();
    this.id = this.products.id;
    this.productName = this.products.productName;
    this.categoryId = this.products.categoryId;
    this.supplierId = this.supplierId;
    this.image = this.products.image;
    this.createDate = this.products.createDate;
    this.updateDate = this.products.updateDate;
    this.description = this.products.description;
    this.shortName = this.products.shortName;
    this.startSale = this.products.startSale;
    this.endSale = this.products.endSale;

  }

  // refresh dữ liệu trả về từ Supplier(SuppList)
  refreshSuppList(){
    this.service.getSuppList().subscribe(data =>{
    //  console.log(data);
     this.SupplierList = data;
    });
  }

  // refresh dữ liệu trả về từ Category(CategoryList)
  refreshCategoList(){
    this.service.getCateList().subscribe(data =>{
     this.CategoryList = data;
    });
  }

  Close(){
    this.showProd.refreshProdList();
  }

  addProducts(){
    var val = {
      id:this.id,
      productName:this.productName,
      categoryId:this.categoryId,
      supplierId:this.supplierId,
      image:this.image,
      createDate:this.createDate,
      updateDate:this.updateDate,
      description:this.description,
      shortName:this.shortName,
      startSale:this.startSale,
      endSale:this.endSale,
    };
    this.service.addProducts(val).subscribe(res =>{
      // alert(res.toString());
      alert("Thêm thành công!");
      this.showProd.refreshProdList();
    });
  }


  updateProducts(){
    var val = {
      id:this.id,
      productName:this.productName,
      categoryId:this.categoryId,
      supplierId:this.supplierId,
      image:this.image,
      createDate:this.createDate,
      updateDate:this.updateDate,
      description:this.description,
      shortName:this.shortName,
      startSale:this.startSale,
      endSale:this.endSale,
    };
    // console.log(val)
    this.service.updateProducts(val).subscribe(res =>{
      // alert(res.toString());
      alert("Đã cập nhật!");
      // this.showProd.closeClick();
      this.showProd.refreshProdList();
    });
  }

}
