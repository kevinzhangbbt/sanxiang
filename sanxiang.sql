/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2005                    */
/* Created on:     2014/10/8 10:25:21                           */
/*==============================================================*/


if exists (select 1
            from  sysindexes
           where  id    = object_id('alarm')
            and   name  = 'Relationship_1_FK'
            and   indid > 0
            and   indid < 255)
   drop index alarm.Relationship_1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('alarm')
            and   type = 'U')
   drop table alarm
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ledger')
            and   type = 'U')
   drop table ledger
go

if exists (select 1
            from  sysobjects
           where  id = object_id('prioritization_scheme')
            and   type = 'U')
   drop table prioritization_scheme
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('sanxiang_data')
            and   name  = 'Relationship_2_FK'
            and   indid > 0
            and   indid < 255)
   drop index sanxiang_data.Relationship_2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('sanxiang_data')
            and   type = 'U')
   drop table sanxiang_data
go

if exists (select 1
            from  sysobjects
           where  id = object_id('structure')
            and   type = 'U')
   drop table structure
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('taiqu_structure')
            and   name  = 'Relationship_4_FK'
            and   indid > 0
            and   indid < 255)
   drop index taiqu_structure.Relationship_4_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('taiqu_structure')
            and   type = 'U')
   drop table taiqu_structure
go

if exists (select 1
            from  sysobjects
           where  id = object_id('taiqu_user')
            and   type = 'U')
   drop table taiqu_user
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('taiqu_user_distribute')
            and   name  = 'taiqu_user_distribute2_FK'
            and   indid > 0
            and   indid < 255)
   drop index taiqu_user_distribute.taiqu_user_distribute2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('taiqu_user_distribute')
            and   name  = 'taiqu_user_distribute_FK'
            and   indid > 0
            and   indid < 255)
   drop index taiqu_user_distribute.taiqu_user_distribute_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('taiqu_user_distribute')
            and   type = 'U')
   drop table taiqu_user_distribute
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('user_load')
            and   name  = 'Relationship_6_FK'
            and   indid > 0
            and   indid < 255)
   drop index user_load.Relationship_6_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('user_load')
            and   type = 'U')
   drop table user_load
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('user_load_forecast')
            and   name  = 'Relationship_7_FK'
            and   indid > 0
            and   indid < 255)
   drop index user_load_forecast.Relationship_7_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('user_load_forecast')
            and   type = 'U')
   drop table user_load_forecast
go

if exists (select 1
            from  sysobjects
           where  id = object_id('users')
            and   type = 'U')
   drop table users
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('watchdog')
            and   name  = 'Relationship_3_FK'
            and   indid > 0
            and   indid < 255)
   drop index watchdog.Relationship_3_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('watchdog')
            and   type = 'U')
   drop table watchdog
go

/*==============================================================*/
/* Table: alarm                                                 */
/*==============================================================*/
create table alarm (
   alarm_id             varchar(40)          not null,
   watchdog_id          varchar(40)          null,
   taiqu_id             varchar(30)          null,
   time                 datetime             not null,
   alarm_type           varchar(50)          not null,
   alarm_rank           varchar(10)          not null,
   process_user         varchar(30)          null,
   status               varchar(10)          not null,
   remark               text                 null,
   constraint PK_ALARM primary key nonclustered (alarm_id)
)
go

/*==============================================================*/
/* Index: Relationship_1_FK                                     */
/*==============================================================*/
create index Relationship_1_FK on alarm (
watchdog_id ASC
)
go

/*==============================================================*/
/* Table: ledger                                                */
/*==============================================================*/
create table ledger (
   ledger_id            varchar(40)          not null,
   constraint PK_LEDGER primary key nonclustered (ledger_id)
)
go

/*==============================================================*/
/* Table: prioritization_scheme                                 */
/*==============================================================*/
create table prioritization_scheme (
   scheme_id            varchar(40)          not null,
   forecast_id          varchar(40)          null,
   scheme_model         varchar(50)          not null,
   time                 datetime             not null,
   start_time           datetime             null,
   end_time             datetime             null,
   detail               text                 not null,
   constraint PK_PRIORITIZATION_SCHEME primary key nonclustered (scheme_id)
)
go

/*==============================================================*/
/* Table: sanxiang_data                                         */
/*==============================================================*/
create table sanxiang_data (
   id                   varchar(40)          not null,
   watchdog_id          varchar(40)          null,
   taiqu_id             varchar(40)          null,
   time                 datetime             not null,
   voltage_a            float(10)            not null,
   voltage_b            float(10)            not null,
   voltage_c            float(10)            not null,
   current_a            float(10)            not null,
   current_b            float(10)            not null,
   current_c            float(10)            not null,
   current_n            float(10)            null,
   frequency            float(10)            null,
   active_power         float(10)            null,
   reactive_power       float(10)            null,
   apparent_power       float(11)            null,
   power_factor         decimal(4,3)         null,
   active_electric_energy float(10)            null,
   reactive_electric_energy float(10)            null,
   apparent_electric_energy float(11)            null,
   voltage_unbalance    decimal(4,3)         not null,
   current_unbalance    decimal(4,3)         not null,
   constraint PK_SANXIANG_DATA primary key nonclustered (id)
)
go

/*==============================================================*/
/* Index: Relationship_2_FK                                     */
/*==============================================================*/
create index Relationship_2_FK on sanxiang_data (
watchdog_id ASC
)
go

/*==============================================================*/
/* Table: structure                                             */
/*==============================================================*/
create table structure (
   struct_id            varchar(40)          not null,
   parent_id            varchar(40)          null,
   name                 varchar(200)         null,
   type                 varchar(10)          not null,
   admin_user           varchar(100)         null,
   constraint PK_STRUCTURE primary key nonclustered (struct_id)
)
go

/*==============================================================*/
/* Table: taiqu_structure                                       */
/*==============================================================*/
create table taiqu_structure (
   taiqu_structure_id   varchar(40)          not null,
   taiqu_id             varchar(40)          null,
   version              int                  not null,
   version_status       varchar(10)          not null,
   constraint PK_TAIQU_STRUCTURE primary key nonclustered (taiqu_structure_id)
)
go

/*==============================================================*/
/* Index: Relationship_4_FK                                     */
/*==============================================================*/
create index Relationship_4_FK on taiqu_structure (
taiqu_id ASC
)
go

/*==============================================================*/
/* Table: taiqu_user                                            */
/*==============================================================*/
create table taiqu_user (
   taiqu_user_id        varchar(40)          not null,
   uid                  varchar(40)          null,
   uname                varchar(20)          not null,
   constraint PK_TAIQU_USER primary key nonclustered (taiqu_user_id)
)
go

/*==============================================================*/
/* Table: taiqu_user_distribute                                 */
/*==============================================================*/
create table taiqu_user_distribute (
   distribute_id        varchar(40)          not null,
   taiqu_user_id        varchar(40)          not null,
   taiqu_structure_id   varchar(40)          not null,
   constraint PK_TAIQU_USER_DISTRIBUTE primary key nonclustered (taiqu_user_id, taiqu_structure_id)
)
go

/*==============================================================*/
/* Index: taiqu_user_distribute_FK                              */
/*==============================================================*/
create index taiqu_user_distribute_FK on taiqu_user_distribute (
taiqu_user_id ASC
)
go

/*==============================================================*/
/* Index: taiqu_user_distribute2_FK                             */
/*==============================================================*/
create index taiqu_user_distribute2_FK on taiqu_user_distribute (
taiqu_structure_id ASC
)
go

/*==============================================================*/
/* Table: user_load                                             */
/*==============================================================*/
create table user_load (
   user_load_id         varchar(40)          not null,
   taiqu_user_id        varchar(40)          null,
   uid                  varchar(40)          null,
   uname                varchar(20)          not null,
   time                 datetime             not null,
   load_total           float(12)            null,
   load_current         float(10)            null,
   constraint PK_USER_LOAD primary key nonclustered (user_load_id)
)
go

/*==============================================================*/
/* Index: Relationship_6_FK                                     */
/*==============================================================*/
create index Relationship_6_FK on user_load (
taiqu_user_id ASC
)
go

/*==============================================================*/
/* Table: user_load_forecast                                    */
/*==============================================================*/
create table user_load_forecast (
   user_load_forecast_id varchar(40)          not null,
   taiqu_user_id        varchar(40)          null,
   forecast_id          varchar(40)          not null,
   uid                  varchar(40)          null,
   uname                varchar(20)          not null,
   time                 datetime             not null,
   forecast_method      varchar(20)          not null,
   start_time           datetime             not null,
   end_time             datetime             not null,
   load_forecast_total  float(12)            null,
   load_forecast_current float(10)            null,
   constraint PK_USER_LOAD_FORECAST primary key nonclustered (user_load_forecast_id)
)
go

/*==============================================================*/
/* Index: Relationship_7_FK                                     */
/*==============================================================*/
create index Relationship_7_FK on user_load_forecast (
taiqu_user_id ASC
)
go

/*==============================================================*/
/* Table: users                                                 */
/*==============================================================*/
create table users (
   user_id              varchar(40)          not null,
   username             varchar(20)          not null,
   password             varchar(30)          not null,
   role                 varchar(100)         null,
   nickname             varchar(30)          null,
   created_time         datetime             not null,
   last_login           datetime             null,
   admin_level          int                  not null,
   constraint PK_USERS primary key nonclustered (user_id)
)
go

/*==============================================================*/
/* Table: watchdog                                              */
/*==============================================================*/
create table watchdog (
   watchdog_id          varchar(40)          not null,
   taiqu_id             varchar(40)          null,
   ip_address           varchar(20)          null,
   constraint PK_WATCHDOG primary key nonclustered (watchdog_id)
)
go

/*==============================================================*/
/* Index: Relationship_3_FK                                     */
/*==============================================================*/
create index Relationship_3_FK on watchdog (
taiqu_id ASC
)
go

