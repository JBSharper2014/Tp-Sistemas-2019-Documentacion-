﻿namespace CapaUsuario
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bienesDeUsoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaCorrienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeRecepciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaDeCréditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.órdenesDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosDeDevoluciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosDeReaprovisionamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NombresUsuarioToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.cobrosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1122, 48);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bienesDeUsoToolStripMenuItem,
            this.controlDeProveedoresToolStripMenuItem,
            this.cuentaCorrienteToolStripMenuItem,
            this.facturaProveedoresToolStripMenuItem,
            this.informeRecepciónToolStripMenuItem,
            this.notaDeCréditoToolStripMenuItem,
            this.órdenesDeCompraToolStripMenuItem,
            this.pedidosDeDevoluciónToolStripMenuItem,
            this.pedidosDeReaprovisionamientoToolStripMenuItem,
            this.registraciónToolStripMenuItem,
            this.remitoToolStripMenuItem,
            this.solicitudesDeCompraToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.comprasToolStripMenuItem.Image = global::CapaUsuario.Properties.Resources.compras64;
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(120, 44);
            this.comprasToolStripMenuItem.Text = "&Compras";
            // 
            // bienesDeUsoToolStripMenuItem
            // 
            this.bienesDeUsoToolStripMenuItem.Image = global::CapaUsuario.Properties.Resources.bienes_de_uso128;
            this.bienesDeUsoToolStripMenuItem.Name = "bienesDeUsoToolStripMenuItem";
            this.bienesDeUsoToolStripMenuItem.Size = new System.Drawing.Size(312, 46);
            this.bienesDeUsoToolStripMenuItem.Text = "&Bienes de Uso";
            this.bienesDeUsoToolStripMenuItem.Click += new System.EventHandler(this.bienesDeUsoToolStripMenuItem_Click);
            // 
            // controlDeProveedoresToolStripMenuItem
            // 
            this.controlDeProveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem,
            this.cotizacionesToolStripMenuItem});
            this.controlDeProveedoresToolStripMenuItem.Image = global::CapaUsuario.Properties.Resources.proveedor_100;
            this.controlDeProveedoresToolStripMenuItem.Name = "controlDeProveedoresToolStripMenuItem";
            this.controlDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(312, 46);
            this.controlDeProveedoresToolStripMenuItem.Text = "&Control de Proveedores";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Image = global::CapaUsuario.Properties.Resources.proveedores128;
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(184, 46);
            this.proveedoresToolStripMenuItem.Text = "&Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // cotizacionesToolStripMenuItem
            // 
            this.cotizacionesToolStripMenuItem.Image = global::CapaUsuario.Properties.Resources.cotizacion96;
            this.cotizacionesToolStripMenuItem.Name = "cotizacionesToolStripMenuItem";
            this.cotizacionesToolStripMenuItem.Size = new System.Drawing.Size(184, 46);
            this.cotizacionesToolStripMenuItem.Text = "&Cotizaciones";
            // 
            // cuentaCorrienteToolStripMenuItem
            // 
            this.cuentaCorrienteToolStripMenuItem.Image = global::CapaUsuario.Properties.Resources.cuenta_corriente64;
            this.cuentaCorrienteToolStripMenuItem.Name = "cuentaCorrienteToolStripMenuItem";
            this.cuentaCorrienteToolStripMenuItem.Size = new System.Drawing.Size(312, 46);
            this.cuentaCorrienteToolStripMenuItem.Text = "C&uentas corriente proveedores";
            // 
            // facturaProveedoresToolStripMenuItem
            // 
            this.facturaProveedoresToolStripMenuItem.Image = global::CapaUsuario.Properties.Resources.facturas128;
            this.facturaProveedoresToolStripMenuItem.Name = "facturaProveedoresToolStripMenuItem";
            this.facturaProveedoresToolStripMenuItem.Size = new System.Drawing.Size(312, 46);
            this.facturaProveedoresToolStripMenuItem.Text = "&Facturas Proveedores";
            // 
            // informeRecepciónToolStripMenuItem
            // 
            this.informeRecepciónToolStripMenuItem.Image = global::CapaUsuario.Properties.Resources.informe_recepcion100;
            this.informeRecepciónToolStripMenuItem.Name = "informeRecepciónToolStripMenuItem";
            this.informeRecepciónToolStripMenuItem.Size = new System.Drawing.Size(312, 46);
            this.informeRecepciónToolStripMenuItem.Text = "&Informes de Recepción";
            // 
            // notaDeCréditoToolStripMenuItem
            // 
            this.notaDeCréditoToolStripMenuItem.Image = global::CapaUsuario.Properties.Resources.nota_credito_80;
            this.notaDeCréditoToolStripMenuItem.Name = "notaDeCréditoToolStripMenuItem";
            this.notaDeCréditoToolStripMenuItem.Size = new System.Drawing.Size(312, 46);
            this.notaDeCréditoToolStripMenuItem.Text = "&Notas de Crédito";
            // 
            // órdenesDeCompraToolStripMenuItem
            // 
            this.órdenesDeCompraToolStripMenuItem.Image = global::CapaUsuario.Properties.Resources.orden_de_compra_100;
            this.órdenesDeCompraToolStripMenuItem.Name = "órdenesDeCompraToolStripMenuItem";
            this.órdenesDeCompraToolStripMenuItem.Size = new System.Drawing.Size(312, 46);
            this.órdenesDeCompraToolStripMenuItem.Text = "&Órdenes de Compra";
            // 
            // pedidosDeDevoluciónToolStripMenuItem
            // 
            this.pedidosDeDevoluciónToolStripMenuItem.Image = global::CapaUsuario.Properties.Resources.devoluciones128;
            this.pedidosDeDevoluciónToolStripMenuItem.Name = "pedidosDeDevoluciónToolStripMenuItem";
            this.pedidosDeDevoluciónToolStripMenuItem.Size = new System.Drawing.Size(312, 46);
            this.pedidosDeDevoluciónToolStripMenuItem.Text = "&Pedidos de devolución";
            // 
            // pedidosDeReaprovisionamientoToolStripMenuItem
            // 
            this.pedidosDeReaprovisionamientoToolStripMenuItem.Image = global::CapaUsuario.Properties.Resources.pedido_reaprov100;
            this.pedidosDeReaprovisionamientoToolStripMenuItem.Name = "pedidosDeReaprovisionamientoToolStripMenuItem";
            this.pedidosDeReaprovisionamientoToolStripMenuItem.Size = new System.Drawing.Size(312, 46);
            this.pedidosDeReaprovisionamientoToolStripMenuItem.Text = "P&edidos de reaprovisionamiento";
            // 
            // registraciónToolStripMenuItem
            // 
            this.registraciónToolStripMenuItem.Image = global::CapaUsuario.Properties.Resources.registracion64;
            this.registraciónToolStripMenuItem.Name = "registraciónToolStripMenuItem";
            this.registraciónToolStripMenuItem.Size = new System.Drawing.Size(312, 46);
            this.registraciónToolStripMenuItem.Text = "&Registración";
            // 
            // remitoToolStripMenuItem
            // 
            this.remitoToolStripMenuItem.Image = global::CapaUsuario.Properties.Resources.remito100;
            this.remitoToolStripMenuItem.Name = "remitoToolStripMenuItem";
            this.remitoToolStripMenuItem.Size = new System.Drawing.Size(312, 46);
            this.remitoToolStripMenuItem.Text = "Re&mito";
            // 
            // solicitudesDeCompraToolStripMenuItem
            // 
            this.solicitudesDeCompraToolStripMenuItem.Image = global::CapaUsuario.Properties.Resources.solicitud_compra_100;
            this.solicitudesDeCompraToolStripMenuItem.Name = "solicitudesDeCompraToolStripMenuItem";
            this.solicitudesDeCompraToolStripMenuItem.Size = new System.Drawing.Size(312, 46);
            this.solicitudesDeCompraToolStripMenuItem.Text = "&Solicitudes de Compra";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Image = global::CapaUsuario.Properties.Resources.producto64;
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(312, 46);
            this.stockToolStripMenuItem.Text = "S&tock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Image = global::CapaUsuario.Properties.Resources.ventas64;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(104, 44);
            this.ventasToolStripMenuItem.Text = "&Ventas";
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Image = global::CapaUsuario.Properties.Resources.pagos48;
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(101, 44);
            this.pagosToolStripMenuItem.Text = "&Pagos";
            // 
            // cobrosToolStripMenuItem
            // 
            this.cobrosToolStripMenuItem.Image = global::CapaUsuario.Properties.Resources.cobros64;
            this.cobrosToolStripMenuItem.Name = "cobrosToolStripMenuItem";
            this.cobrosToolStripMenuItem.Size = new System.Drawing.Size(108, 44);
            this.cobrosToolStripMenuItem.Text = "C&obros";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::CapaUsuario.Properties.Resources.exit64;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(88, 44);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NombresUsuarioToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 585);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1122, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // NombresUsuarioToolStripStatusLabel
            // 
            this.NombresUsuarioToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombresUsuarioToolStripStatusLabel.Name = "NombresUsuarioToolStripStatusLabel";
            this.NombresUsuarioToolStripStatusLabel.Size = new System.Drawing.Size(146, 20);
            this.NombresUsuarioToolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 610);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuPrincipal";
            this.Text = "Sistema comercial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bienesDeUsoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaCorrienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeRecepciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaDeCréditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem órdenesDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosDeDevoluciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosDeReaprovisionamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem remitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel NombresUsuarioToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

