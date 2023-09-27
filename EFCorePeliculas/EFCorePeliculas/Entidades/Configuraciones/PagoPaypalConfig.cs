﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCorePeliculas.Entidades.Configuraciones
{
    public class PagoPaypalConfig : IEntityTypeConfiguration<PagoPaypal>
    {
        public void Configure(EntityTypeBuilder<PagoPaypal> builder)
        {
            builder.Property(x => x.CorreoElectronico).HasMaxLength(150).IsRequired();

            var pago1 = new PagoPaypal()
            {
                Id = 3,
                FechaTransaccion = new DateTime(2022, 1, 7),
                Monto = 157,
                TipoPago = TipoPago.Paypal,
                CorreoElectronico = "felipe@gmail.com"
            };

            var pago2 = new PagoPaypal()
            {
                Id = 4,
                FechaTransaccion = new DateTime(2022, 1, 7),
                Monto = 9.99m,
                TipoPago = TipoPago.Paypal,
                CorreoElectronico = "juan@gmail.com"
            };

            builder.HasData(pago1, pago2);
        }
    }
}