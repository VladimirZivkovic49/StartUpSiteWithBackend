import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutCompanyComponent } from './about-company/about-company.component';
import { ContactComponent } from './contact/contact.component';
import { HomeComponent } from './home/home.component';
import { TeamMembersComponent } from './teamInHouse/team-members/team-members.component';

const routes: Routes = 
[
  {path:'',component:HomeComponent},
  {path:'app-about-company',component:AboutCompanyComponent},
  {path:'contact',component:ContactComponent},
  { path:'teamMembers', component:TeamMembersComponent },
  {path:'**',component:HomeComponent,pathMatch:'full'}


];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
