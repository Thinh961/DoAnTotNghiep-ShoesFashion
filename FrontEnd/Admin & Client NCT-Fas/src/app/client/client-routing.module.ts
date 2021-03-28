import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { ClientDefaultLayoutComponent } from '../containers/client-default-layout/client-default-layout.component';
import { ClientComponent } from "./client.component";
import { HomeComponent } from "./pages/home/home.component";

const routes: Routes = [
  { path: "", component: HomeComponent },
  // { path: "home", component: HomeComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class ClientRoutingModule {}
