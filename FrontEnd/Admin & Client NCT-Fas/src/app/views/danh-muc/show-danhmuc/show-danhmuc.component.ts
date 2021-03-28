import { Component, OnInit } from '@angular/core';
import { SharedService } from "../../../_services/shared.service"

@Component({
  selector: 'app-show-danhmuc',
  templateUrl: './show-danhmuc.component.html',
  styleUrls: ['./show-danhmuc.component.scss']
})
export class ShowDanhmucComponent implements OnInit {

  constructor(private service:SharedService) { }

  CategoryList:any=[];


  ModalTitle:string;
  ActivateAddEdit:boolean=false;
  category:any;

  ngOnInit() {
    this.refreshCateList();
  }

  // Thêm sản phẩm
  addClick(){
    this.category={
      id:0,
      categoryName:"",
      description:"",
    }
    this.ModalTitle="Thêm danh mục";
    this.ActivateAddEdit=true;
  }

  editClick(item){
    this.category=item;
    this.ModalTitle="Sửa danh mục";
    this.ActivateAddEdit=true;
  }

  deleteClick(item){
    if(confirm("Bạn có chắc chắn xóa?")){
      this.service.deleteCate(item.id).subscribe(data =>{
        alert("Xóa thành công!")
        this.refreshCateList();
      })
    }
  }

  closeClick(){
    this.ActivateAddEdit=false;
    this.refreshCateList();
  }

  // refresh dữ liệu trả về từ Products(ProductsList)
  refreshCateList(){
    this.service.getCateList().subscribe(data=>{
      this.CategoryList=data;
      // this.DepartmentListWithoutFilter=data;
    });
  }

}
