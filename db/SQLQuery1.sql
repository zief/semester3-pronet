--buat tabel-tabel 
CREATE TABLE admin(
userId VARCHAR(10) NOT NULL PRIMARY KEY,
password VARCHAR(10) NOT NULL
);
CREATE TABLE customer(
idCustomer VARCHAR(6) NOT NULL PRIMARY KEY,
namaCustomer VARCHAR(20) NOT NULL,
nominalIsi INT NOT NULL DEFAULT 0
);
CREATE TABLE menu(
idMenu VARCHAR(5) NOT NULL PRIMARY KEY,
namaMenu VARCHAR(20) NOT NULL,
harga INT NOT NULL
);
CREATE TABLE transaksi(
idTransaksi VARCHAR(10) NOT NULL PRIMARY KEY,
tglTransaksi CHAR(10) NOT NULL,
idCustomer VARCHAR(6) NOT NULL,
CONSTRAINT FK_CUSTOMER FOREIGN KEY (idCustomer) REFERENCES
customer(idCustomer)
);
CREATE TABLE detailTransaksi(
idTransaksi VARCHAR(10) NOT NULL,
idMenu VARCHAR(5) NOT NULL,
CONSTRAINT FK_TRANSAKSI FOREIGN KEY (idTransaksi) REFERENCES
transaksi(idTransaksi),
CONSTRAINT FK_MENU FOREIGN KEY (idMenu) REFERENCES menu(idMenu)
);

drop table customer;