package az.code.models;

import lombok.AllArgsConstructor;
import lombok.Builder;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.*;

@Entity
@Data
@Builder
@NoArgsConstructor
@AllArgsConstructor
public class Car {
    @Id
    @GeneratedValue(
            strategy = GenerationType.SEQUENCE,
            generator = "seq_post"
    )
    @SequenceGenerator(
            name = "seq_post",
            allocationSize = 1,
            initialValue = 1
    )

    private Long id;
    String brand;
    String model;

}
