import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HomeComponent } from './home/home.component';
import { ErrorComponent } from './error/error.component';
import {Routes,RouterModule} from '@angular/router'
import { LoaderComponent } from './loader/loader.component';
import { AboutComponent } from './about/about.component';
import { NavbarComponent } from './navbar/navbar.component';
import { TranslateLoader, TranslateModule } from '@ngx-translate/core';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { MobileNavbarComponent } from './mobile-navbar/mobile-navbar.component';
import {MatButtonModule} from '@angular/material/button';
import {MatSidenavModule} from "@angular/material/sidenav";
import {MatRadioModule} from "@angular/material/radio";
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatSelectModule} from '@angular/material/select';
import {MatInputModule} from '@angular/material/input';
import {MatTabsModule} from '@angular/material/tabs';
import {MatExpansionModule} from '@angular/material/expansion';
import {MatIconModule} from '@angular/material/icon';
import {MatCheckboxModule} from '@angular/material/checkbox';
import {MatDatepickerModule,} from '@angular/material/datepicker';
import {MatToolbarModule,} from '@angular/material/toolbar';
import {MatListModule} from '@angular/material/list';
import { FooterComponent } from './footer/footer.component';
import { BannerComponent } from './banner/banner.component';
import { ShopingComponent } from './shoping/shoping.component';
import { TariffsComponent } from './tariffs/tariffs.component';
import { CalculatorComponent } from './calculator/calculator.component';
import { CourierComponent } from './courier/courier.component';
import { NewsComponent } from './news/news.component';
import { CarouselModule } from 'ngx-owl-carousel-o';
import { FaqComponent } from './faq/faq.component';
import { ContactComponent } from './contact/contact.component';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
import { ServiceComponent } from './service/service.component';
import { TitleComponent } from './title/title.component';
import { RegisterComponent } from './register/register.component';
import { MatNativeDateModule } from '@angular/material/core';
import { LoginComponent } from './login/login.component';
import { RestoreComponent } from './restore/restore.component';
import {RxReactiveFormsModule} from '@rxweb/reactive-form-validators';
import { NgApexchartsModule } from "ng-apexcharts";
import { MyprofileComponent } from './myprofile/myprofile.component';
import {MatPaginatorModule} from '@angular/material/paginator';
import {MatTableModule} from '@angular/material/table';
import {MatSortModule} from '@angular/material/sort';
import {MatDialogModule} from '@angular/material/dialog';
import {MatChipsModule} from '@angular/material/chips';
import {MatAutocompleteModule} from '@angular/material/autocomplete';
import { StatementDialogComponent } from './myprofile/dialogs/statement-dialog/statement-dialog.component';
import { ControlPanelComponent } from './myprofile/control-panel/control-panel.component';
import { CountriesComponent } from './myprofile/countries/countries.component';
import { StatementsComponent } from './myprofile/statements/statements.component';
import { OrdersComponent } from './myprofile/orders/orders.component';
import { OrderDialogComponent } from './myprofile/dialogs/order-dialog/order-dialog.component';
import {DashboardComponent} from './Admin/dashboard/dashboard.component';
import {LayoutComponent} from './Admin/layout/layout.component';
import { UsersComponent } from './Admin/users/users.component';
import { TitleAdminComponent } from './Admin/title-admin/title-admin.component';
import { RoleDialogComponent } from './Admin/dialogs/auth/role-dialog/role-dialog.component';
import { ResetDialogComponent } from './Admin/dialogs/auth/reset-dialog/reset-dialog.component';
import { InfoDialogComponent } from './Admin/dialogs/auth/info-dialog/info-dialog.component';
import { InfoBusinessDialogComponent } from './Admin/dialogs/auth/info-business-dialog/info-business-dialog.component';
import { CountriesAllComponent } from './Admin/countries-all/countries-all.component';
import { CountryEditDialogComponent } from './Admin/dialogs/country/country-edit-dialog/country-edit-dialog.component';
import { CountryCreateDialogComponent } from './Admin/dialogs/country/country-create-dialog/country-create-dialog.component';
import { CountryInfoComponent } from './Admin/countries-all/country-info/country-info.component';
import { CountryInfoCreateComponent } from './Admin/dialogs/country/country-info-create/country-info-create.component';
import { CountryInfoEditComponent } from './Admin/dialogs/country/country-info-edit/country-info-edit.component';
import { OfficesComponent } from './Admin/offices/offices.component';
import {AuthOutGuard} from './Core/guards/auth-out.guard';
import {AuthGuard} from './Core/guards/auth.guard';
import {CoreModule} from './Core/core.module';
import {LanguagesService} from './Core/services/lang/languages.service';
import {GlobalService} from './Core/services/global/global.service';
import { CreateOfficeComponent } from './Admin/dialogs/office/create-office/create-office.component';
import { UpdateOfficeComponent } from './Admin/dialogs/office/update-office/update-office.component';
import { CitiesComponent } from './Admin/cities/cities.component';
import { CreateCityComponent } from './Admin/dialogs/city/create-city/create-city.component';
import { UpdateCityComponent } from './Admin/dialogs/city/update-city/update-city.component';
import { ProductsComponent } from './Admin/products/products.component';
import { CreatePtoductComponent } from './Admin/dialogs/product/create-ptoduct/create-ptoduct.component';
import { UpdateProductComponent } from './Admin/dialogs/product/update-product/update-product.component';
import { StatementUpdateComponent } from './myprofile/dialogs/statement-update/statement-update.component';
import { BalanceDialogComponent } from './myprofile/dialogs/balance-dialog/balance-dialog.component';
import {MatMenuModule} from '@angular/material/menu';
import { UserOrdersComponent } from './Admin/users/user-orders/user-orders.component';
import { OrderInfoComponent } from './Admin/dialogs/order/order-info/order-info.component';
import { AddToAnbarComponent } from './Admin/dialogs/cargo/add-to-anbar/add-to-anbar.component';
import { WaitingInvoiceComponent } from './myprofile/waiting-invoice/waiting-invoice.component';
import { WaitingInvoiceDialogComponent } from './myprofile/dialogs/waiting-invoice-dialog/waiting-invoice-dialog.component';
import { InAnbarComponent } from './myprofile/in-anbar/in-anbar.component';
import { OrderInProcessComponent } from './Admin/order-in-process/order-in-process.component';
import { OrderProcessedComponent } from './Admin/order-processed/order-processed.component';
import { StatemetsAdminComponent } from './Admin/statemets-admin/statemets-admin.component';
import { AddStatementToAnbarComponent } from './Admin/dialogs/add-statement-to-anbar/add-statement-to-anbar.component';
import { ParcelsComponent } from './Admin/parcels/parcels.component';
import { StatusChangeComponent } from './Admin/dialogs/status-change/status-change.component';
import { EndedComponent } from './myprofile/ended/ended.component';
import { AddToAnbarNewParcelComponent } from './Admin/dialogs/add-to-anbar-new-parcel/add-to-anbar-new-parcel.component';
import { ParcelInfoComponent } from './Admin/dialogs/parcel-info/parcel-info.component';
import { ShopsComponent } from './Admin/shops/shops.component';
import { ShopLinkComponent } from './Admin/shops/shop-link/shop-link.component';
import { ShopCreateDialogComponent } from './Admin/dialogs/shop/shop-create-dialog/shop-create-dialog.component';
import { ShopUpdateDialogComponent } from './Admin/dialogs/shop/shop-update-dialog/shop-update-dialog.component';
import { ShopLinkUpdateDialogComponent } from './Admin/dialogs/shop/shop-link-update-dialog/shop-link-update-dialog.component';
import { ShopLinkCreateDialogComponent } from './Admin/dialogs/shop/shop-link-create-dialog/shop-link-create-dialog.component';
import { CountryTariffComponent } from './Admin/countries-all/country-tariff/country-tariff.component';
import { TariffPricesComponent } from './Admin/countries-all/country-tariff/tariff-prices/tariff-prices.component';
import { TariffUpdateComponent } from './Admin/dialogs/country/tariff-update/tariff-update.component';
import { TariffCreateComponent } from './Admin/dialogs/country/tariff-create/tariff-create.component';
import { PriceCreateComponent } from './Admin/dialogs/country/price-create/price-create.component';
import { PriceUpdateComponent } from './Admin/dialogs/country/price-update/price-update.component';
import { CourierServiceComponent } from './Admin/courier-service/courier-service.component';
import { CourierCreateComponent } from './Admin/dialogs/courier/courier-create/courier-create.component';
import { CourierUpdateComponent } from './Admin/dialogs/courier/courier-update/courier-update.component';
import { FAQAdminComponent } from './Admin/faqadmin/faqadmin.component';
import { ServiceAdminComponent } from './Admin/service-admin/service-admin.component';
import { FaqCreateComponent } from './Admin/dialogs/faq/faq-create/faq-create.component';
import { FaqUpdateComponent } from './Admin/dialogs/faq/faq-update/faq-update.component';
import { ServiceUpdateComponent } from './Admin/dialogs/service/service-update/service-update.component';
import { ServiceCreateComponent } from './Admin/dialogs/service/service-create/service-create.component';
import { CKEditorModule } from '@ckeditor/ckeditor5-angular';
import { MessagesComponent } from './Admin/messages/messages.component';
import { AnswerUserComponent } from './Admin/dialogs/answer-user/answer-user.component';
import { FlightComponent } from './Admin/flight/flight.component';
import { CreateNewsComponent } from './Admin/dialogs/news/create-news/create-news.component';
import { UpdateNewsComponent } from './Admin/dialogs/news/update-news/update-news.component';
import { UpdateFlightComponent } from './Admin/dialogs/flight/update-flight/update-flight.component';
import { CreateFlightComponent } from './Admin/dialogs/flight/create-flight/create-flight.component';
import {NewsAdminComponent} from './Admin/news-admin/news-admin.component';
import { NewsDetailsComponent } from './news-details/news-details.component';
import { UserSettingsComponent } from './myprofile/user-settings/user-settings.component';
import {AdminPanelGuard} from './Core/guards/admin-panel.guard';
import { RestorePasswordComponent } from './restore-password/restore-password.component';
import { BioComponent } from './Admin/bio/bio.component';
import { AboutUsComponent } from './Admin/about-us/about-us.component';
import { ContactNoticeComponent } from './Admin/contact-notice/contact-notice.component';
const routes: Routes=[
  { path: "home", redirectTo:"" ,pathMatch:"full"},
  { path:"",  component:HomeComponent },
  { path:"about",  component:AboutComponent, data: {animation: 'About'}},
  { path:"shopping",  component:ShopingComponent, data: {animation: 'Shopping'} },
  { path:"tariffs",  component:TariffsComponent, data: {animation: 'Tariffs'} },
  { path:"calculator",  component:CalculatorComponent, data: {animation: 'Calculator'} },
  { path:"courier",  component:CourierComponent, data: {animation: 'Courier'} },
  { path:"news",  component:NewsComponent, data: {animation: 'News'} },
  { path:"news/:id",  component:NewsDetailsComponent, data: {animation: 'NewsDetails'} },
  { path:"faq",  component:FaqComponent, data: {animation: 'Faq'} },
  { path:"contact",  component:ContactComponent, data: {animation: 'Contact'} },
  { path:"services",  component:ServiceComponent, data: {animation: 'Services'} },
  { path:"register",  component:RegisterComponent, data: {animation: 'Register'}, canActivate: [AuthOutGuard] },
  { path:"login",  component:LoginComponent, data: {animation: 'Login'},canActivate: [AuthOutGuard]},
  { path:"restore",  component:RestoreComponent, data: {animation: 'Restore'}, canActivate: [AuthOutGuard] },
  { path:"restore/:id",  component:RestorePasswordComponent, data: {animation: 'Restore'}, canActivate: [AuthOutGuard] },
  { path:"myprofile/statements", redirectTo:"myprofile" },
  { path:"myprofile/control-panel", redirectTo:"myprofile" },
  { path:"myprofile/countries", redirectTo:"myprofile" },
  { path:"myprofile/orders", redirectTo:"myprofile" },
  { path:"myprofile/waiting-invoice", redirectTo:"myprofile" },
  { path:"myprofile/settings", redirectTo:"myprofile" },
  { path:"myprofile",  component:MyprofileComponent, data: {animation: 'Myprofile'}, canActivate: [AuthGuard] },
  {
    path: 'admin',
    children: [
      {
        path: '',
        component: UsersComponent,
        data: {animation: 'admin'},
      },
      {
        path: 'dashboard',
        component: DashboardComponent,
        data: {animation: 'dashboard'},
      },
      {
        path: 'users',
        component: UsersComponent,
        data: {animation: 'users'},
      },
      {
        path: 'replies',
        component: MessagesComponent,
        data: {animation: 'replies'},
      },
      {
        path: 'users/orders/:id',
        component: UserOrdersComponent,
        data: {animation: 'userId'},
      },
      {
        path: 'order-in-process',
        component: OrderInProcessComponent,
        data: {animation: 'OrderInProcess'},
      },
      {
        path: 'about-description',
        component: AboutUsComponent,
        data: {animation: 'aboutDescription'},
      },
      {
        path: 'contact-notice',
        component: ContactNoticeComponent,
        data: {animation: 'contactNotice'},
      },
      {
        path: 'bio',
        component: BioComponent,
        data: {animation: 'Bio'},
      },
      {
        path: 'order-processed',
        component: OrderProcessedComponent,
        data: {animation: 'OrderProcessed'},
      },
      {
        path: 'statements',
        component: StatemetsAdminComponent,
        data: {animation: 'Statements'},
      },
      {
        path: 'users/statements/:id',
        component: StatemetsAdminComponent,
        data: {animation: 'Statements'},
      },
      {
        path: 'parcels/InAnbar',
        component: ParcelsComponent,
        data: {animation: 'InAnbar',status:'InAnbar'},
      },
      {
        path: 'parcels/InWay',
        component: ParcelsComponent,
        data: {animation: 'InWay',status:'InWay'},
      },
      {
        path: 'parcels/In??ustoms',
        component: ParcelsComponent,
        data: {animation: 'In??ustoms',status:'In??ustoms'},
      },
      {
        path: 'parcels/InOffice',
        component: ParcelsComponent,
        data: {animation: 'InOffice',status:'InOffice'},
      },
      {
        path: 'parcels/end',
        component: ParcelsComponent,
        data: {animation: 'End',status:'End'},
      },
      {
        path: 'parcels/InAnbar/:id',
        component: ParcelsComponent,
        data: {animation: 'InAnbar',status:'InAnbar'},
      },
      {
        path: 'parcels/InWay/:id',
        component: ParcelsComponent,
        data: {animation: 'InWay',status:'InWay'},
      },
      {
        path: 'parcels/In??ustoms/:id',
        component: ParcelsComponent,
        data: {animation: 'In??ustoms',status:'In??ustoms'},
      },
      {
        path: 'parcels/InOffice/:id',
        component: ParcelsComponent,
        data: {animation: 'InOffice',status:'InOffice'},
      },
      {
        path: 'parcels/end/:id',
        component: ParcelsComponent,
        data: {animation: 'End',status:'End'},
      },
      {
        path: 'countries',
        component: CountriesAllComponent,
        data: {animation: 'countries'},
      },
      {
        path: 'countries/:id',
        component: CountryInfoComponent,
        data: {animation: 'countriesId'},
      },
      {
        path: 'countries/tariffs/:id',
        component: CountryTariffComponent,
        data: {animation: 'tariffsCountry'},
      },
      {
        path: 'countries/tariffs/:id/prices/:id',
        component: TariffPricesComponent,
        data: {animation: 'tariffsPrices'},
      },

      {
        path: 'offices',
        component: OfficesComponent,
        data: {animation: 'offices'},
      },
      {
        path: 'shops',
        component: ShopsComponent,
        data: {animation: 'shops'},
      },
      {
        path: 'shops/:id',
        component: ShopLinkComponent,
        data: {animation: 'shop-link'},
      },
      {
        path: 'courier-service',
        component: CourierServiceComponent,
        data: {animation: 'CourierService'},
      },
      {
        path: 'faq',
        component: FAQAdminComponent,
        data: {animation: 'faq'},
      },
      {
        path: 'news',
        component: NewsAdminComponent,
        data: {animation: 'news'},
      },
      {
        path: 'flights',
        component: FlightComponent,
        data: {animation: 'flights'},
      },
      {
        path: 'service',
        component: ServiceAdminComponent,
        data: {animation: 'service'},
      },
      {
        path: 'cities',
        component: CitiesComponent,
        data: {animation: 'cities'},
      },
      {
        path: 'products',
        component: ProductsComponent,
        data: {animation: 'products'},
      },
      {
        path: '**',
        component: ErrorComponent,
        data: {animation: 'errorr'},
      },
    ],
    canActivate: [AdminPanelGuard],

  },
  { path:"**", component:ErrorComponent,data: {animation: 'Error'}}
]

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ErrorComponent,
    LoaderComponent,
    AboutComponent,
    NavbarComponent,
    MobileNavbarComponent,
    FooterComponent,
    BannerComponent,
    ShopingComponent,
    TariffsComponent,
    CalculatorComponent,
    CourierComponent,
    NewsComponent,
    FaqComponent,
    ContactComponent,
    ServiceComponent,
    TitleComponent,
    RegisterComponent,
    LoginComponent,
    RestoreComponent,
    MyprofileComponent,
    StatementDialogComponent,
    ControlPanelComponent,
    CountriesComponent,
    StatementsComponent,
    OrdersComponent,
    OrderDialogComponent,
    LayoutComponent,
    DashboardComponent,
    LayoutComponent,
    UsersComponent,
    TitleAdminComponent,
    RoleDialogComponent,
    ResetDialogComponent,
    InfoDialogComponent,
    InfoBusinessDialogComponent,
    CountriesAllComponent,
    CountryEditDialogComponent,
    CountryCreateDialogComponent,
    CountryInfoComponent,
    CountryInfoCreateComponent,
    CountryInfoEditComponent,
    OfficesComponent,
    CreateOfficeComponent,
    UpdateOfficeComponent,
    CitiesComponent,
    CreateCityComponent,
    UpdateCityComponent,
    ProductsComponent,
    CreatePtoductComponent,
    UpdateProductComponent,
    StatementUpdateComponent,
    BalanceDialogComponent,
    UserOrdersComponent,
    OrderInfoComponent,
    AddToAnbarComponent,
    WaitingInvoiceComponent,
    WaitingInvoiceDialogComponent,
    InAnbarComponent,
    OrderInProcessComponent,
    OrderProcessedComponent,
    StatemetsAdminComponent,
    AddStatementToAnbarComponent,
    ParcelsComponent,
    StatusChangeComponent,
    EndedComponent,
    AddToAnbarNewParcelComponent,
    ParcelInfoComponent,
    ShopsComponent,
    ShopLinkComponent,
    ShopCreateDialogComponent,
    ShopUpdateDialogComponent,
    ShopLinkUpdateDialogComponent,
    ShopLinkCreateDialogComponent,
    CountryTariffComponent,
    TariffPricesComponent,
    TariffUpdateComponent,
    TariffCreateComponent,
    PriceCreateComponent,
    PriceUpdateComponent,
    CourierServiceComponent,
    CourierCreateComponent,
    CourierUpdateComponent,
    FAQAdminComponent,
    ServiceAdminComponent,
    FaqCreateComponent,
    FaqUpdateComponent,
    ServiceUpdateComponent,
    ServiceCreateComponent,
    MessagesComponent,
    AnswerUserComponent,
    FlightComponent,
    CreateNewsComponent,
    UpdateNewsComponent,
    UpdateFlightComponent,
    CreateFlightComponent,
    NewsAdminComponent,
    NewsDetailsComponent,
    UserSettingsComponent,
    RestorePasswordComponent,
    BioComponent,
    AboutUsComponent,
    ContactNoticeComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    RouterModule.forRoot(routes),
    MatFormFieldModule,
    MatSelectModule,
    HttpClientModule,
    MatButtonModule,
    CarouselModule,
    CoreModule,
    TranslateModule.forRoot({
      loader: {
        provide: TranslateLoader,
        useFactory: httpTranslateLoader,
        deps: [HttpClient]
      }
    }),
    MatSidenavModule,
    MatRadioModule,
    MatInputModule,
    MatTabsModule,
    MatExpansionModule,
    ReactiveFormsModule,
    MatIconModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatCheckboxModule,
    RxReactiveFormsModule,
    NgApexchartsModule,
    MatPaginatorModule,
    MatTableModule,
    MatSortModule,
    MatDialogModule,
    FormsModule,
    MatToolbarModule,
    MatListModule,
    MatAutocompleteModule,
    MatChipsModule,
    MatMenuModule,
    CKEditorModule
  ],
  exports: [
    RouterModule,
    LayoutComponent
  ],
  providers: [
    LanguagesService,
    GlobalService,
    MatDatepickerModule,
    MatFormFieldModule,
    MatSelectModule,
    MatButtonModule,
    MatSidenavModule,
    MatRadioModule,
    MatInputModule,
    MatTabsModule,
    MatExpansionModule,
    MatIconModule,
    MatChipsModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatCheckboxModule,
    MatPaginatorModule,
    MatAutocompleteModule,
    MatTableModule,
    MatSortModule,
    MatDialogModule,
    MatToolbarModule,
    MatListModule,
    MatMenuModule
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
export function httpTranslateLoader(http: HttpClient) {
  return new TranslateHttpLoader(http);
}
