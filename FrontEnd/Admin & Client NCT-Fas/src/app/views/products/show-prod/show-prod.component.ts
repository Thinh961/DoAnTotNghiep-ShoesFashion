import { Component, OnInit } from '@angular/core';
import { SharedService } from "../../../_services/shared.service"

@Component({
  selector: 'app-show-prod',
  templateUrl: './show-prod.component.html',
  styleUrls: ['./show-prod.component.scss']
})
export class ShowProdComponent implements OnInit {

  constructor(private service:SharedService) { }

  ProductsList:any=[];


  ModalTitle:string;
  ActivateAddEdit:boolean=false;
  products:any;

  ngOnInit() {
    this.refreshProdList();
  }

  // Thêm sản phẩm
  addClick(){
    this.products={
      id:0,
      productName:"",
      categoryId:"",
      supplierId:"",
      image:"",
      createDate:"",
      updateDate:"",
      description:"",
      shortName:"",
      startSale:"",
      endSale:"",
    }
    this.ModalTitle="Thêm sản phẩm";
    this.ActivateAddEdit=true;
  }

  editClick(item){
    this.products=item;
    this.ModalTitle="Sửa sản phẩm";
    this.ActivateAddEdit=true;
  }

  deleteClick(item){
    if(confirm("Bạn có chắc chắn xóa?")){
      this.service.deleteProducts(item.id).subscribe(data =>{
        alert("Xóa thành công!")
        this.refreshProdList();
      })
    }
  }

  closeClick(){
    this.ActivateAddEdit=false;
    this.refreshProdList();
  }

  // refresh dữ liệu trả về từ Products(ProductsList)
  refreshProdList(){
    this.service.getProdList().subscribe(data=>{
      this.ProductsList=data;
      // this.DepartmentListWithoutFilter=data;
    });
  }

}
